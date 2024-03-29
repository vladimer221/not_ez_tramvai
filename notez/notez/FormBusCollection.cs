using notez.CollectionGenericObjects;
using notez.Drawnings;

namespace notez;

public partial class FormBusCollection : Form
{

    private readonly StorageCollection<DrawningTramvaiBus> _storageCollection;

    private AbstractCompany? _company = null;

    public FormBusCollection()
    {
        InitializeComponent();
        _storageCollection = new();
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

        if (_company + bus)

        {
            MessageBox.Show("Обьект добавлен");
            pictureBox.Image = _company.Show();
        }
        else
        {
            MessageBox.Show("Не удалось добавить обьект");
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
        if (_company - pos)
        {
            MessageBox.Show("Обьект удален");
            pictureBox.Image = _company.Show();
        }
        else
        {
            MessageBox.Show("Не удалось удалить обьект");
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
}