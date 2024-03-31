using Microsoft.Extensions.Logging;
using notez.CollectionGenericObjects;
using notez.Drawnings;

namespace notez;

public partial class FormBusCollection : Form
{

    private readonly StorageCollection<DrawningTramvaiBus> _storageCollection;

    private AbstractCompany? _company = null;

    private readonly ILogger _logger;
    public FormBusCollection(ILogger<FormBusCollection> logger)
    {
        InitializeComponent();
        _storageCollection = new();
        _logger = logger;
    }

    private void ComboBoxSelectorCompany_SelectedindexChanged(object sender, EventArgs e)
    {
        panelCompanyTools.Enabled = false;
    }

    private void ButtonAddBus_Click(object sender, EventArgs e)
    {
        ForBusConfig form = new();
        form.addEvent(SetBus);
        form.Show();
    }

    private void SetBus(DrawningTramvaiBus bus)
    {
        if (_company == null || bus == null)
        {
            return;
        }
        try
        {
            if (_company + bus)
            {
                string[]? array = bus?.ClassTramvaiBus?.GetStringRepresentation();
                string bus_string = string.Join(":", array);
                MessageBox.Show("Обьект добавлен");
                pictureBox.Image = _company.Show();
                _logger.LogInformation("Трамвай добавлен" + bus_string);
            }
                    
        }

        catch(Exception ex)
        {
            MessageBox.Show(ex.Message);
            _logger.LogError("ошибка: {Message}", ex.Message);
        }

    }


    private void ButtonRemoveBus_Click(object sender, EventArgs e)
    {

        if (string.IsNullOrEmpty(maskedTextBox.Text) || _company == null)
        {
            return;
        }

        if (MessageBox.Show("Удалить обьект?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        {
            return;
        }

        int pos = Convert.ToInt32(maskedTextBox.Text);

        try
        {
            if (_company - pos)


            {
                MessageBox.Show("Обьект удален");
                pictureBox.Image = _company.Show();
                _logger.LogInformation("Автобус удален" + pos);

            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            _logger.LogError("Ошибка:{Message}", ex.Message);
        }   
    
    }

    private void ButtonGoToCheck_Click(object sender, EventArgs e)
    {
        if (_company == null)
        {
            return;
        }

        DrawningTramvaiBus? bus = null;
        int counter = 100;
        while (bus == null)
        {
            bus = _company.GetRandomObject();
            counter--;
            if (counter == 0)
            {
                break;
            }
        }

        if (bus == null)
        {
            return;
        }

        Formbus form = new()
        {
            SetCar = bus
        };
        form.ShowDialog();
    }

    private void ButtonRefresh_Click(object sender, EventArgs e)
    {
        if (_company == null)
        {
            return;
        }


        pictureBox.Image = _company.Show();
    }

    private void ButtonCollectionAdd_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(textBoxCollectionName.Text) || (!radioButtonList.Checked && !radioButtonMassive.Checked))
        {
            MessageBox.Show("Не все данные заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        CollectionType collectionType = CollectionType.None;
        if (radioButtonMassive.Checked)
        {
            collectionType = CollectionType.Massive;
        }
        else if (radioButtonList.Checked)
        {
            collectionType |= CollectionType.LinkedList;
        }

        _storageCollection.AddCollection(textBoxCollectionName.Text, collectionType);
        RerfreshListBoxItems();

    }

    private void ButtonCollectionDel_Click(object sender, EventArgs e)
    {
        if (listBoxCollection.SelectedIndex < 0 || listBoxCollection.SelectedItem == null)
        {
            MessageBox.Show("Коллекция не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (MessageBox.Show("Вы уверены, что хотите удалить эту коллекцию?", "Подтвердите удаление",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        {
            return;
        }

        string selectedCollectionName = listBoxCollection.SelectedItem.ToString();
        _storageCollection.DelCollection(selectedCollectionName);


        RerfreshListBoxItems();
    }
    private void RerfreshListBoxItems()
    {
        listBoxCollection.Items.Clear();
        for (int i = 0; i < _storageCollection.Keys?.Count; ++i)
        {
            string? colName = _storageCollection.Keys?[i];
            if (!string.IsNullOrEmpty(colName))
            {
                listBoxCollection.Items.Add(colName);
            }
        }
    }

    private void ButtonCreateCompany_Click(object sender, EventArgs e)
    {
        if (listBoxCollection.SelectedIndex < 0 || listBoxCollection.SelectedItem == null)
        {
            MessageBox.Show("Коллекция не выбрана");
            return;
        }
        ICollectionGenericObjects<DrawningTramvaiBus>? collection = _storageCollection[listBoxCollection.SelectedItem.ToString() ?? string.Empty];
        if (collection == null)
        {
            MessageBox.Show("Коллекция не проинициализирована");
            return;
        }

        switch (comboBoxSelectorCompany.Text)
        {
            case "Автовокзал":
                _company = new CarSharingService(pictureBox.Width, pictureBox.Height, collection);
                break;
        }

        panelCompanyTools.Enabled = true;
        RerfreshListBoxItems();
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        { 
            try
            {
                _storageCollection.SaveData(saveFileDialog.FileName);
                MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _logger.LogInformation("Сохранение в файле: {filename}", saveFileDialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.LogError("Ошибка: {Message}", ex.Message);
            }
        }
    }

    private void loadToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                _storageCollection.LoadData(openFileDialog.FileName);
                MessageBox.Show("Загрузка прошла успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _logger.LogInformation("Загрузка файла: {filename}", openFileDialog.FileName);
                RerfreshListBoxItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.LogError("Ошибка: {Message}", ex.Message);
            }

        }
    }


}