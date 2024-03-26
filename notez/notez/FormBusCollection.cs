using notez.CollectionGenericObjects;
using notez.Drawnings;

namespace notez;

public partial class FormBusCollection : Form
{
    private AbstractCompany? _company = null;


    public FormBusCollection()
    {
        InitializeComponent();
    }

    private void ComboBoxSelectorCompany_SelectedindexChanged(object sender, EventArgs e)
    {
        switch (comboBoxSelectorCompany.Text)
        {
            case "Автовокзал":
                _company = new CarSharingService(pictureBox.Width, pictureBox.Height, new MassiveGenericObjects<DrawningTramvaiBus>());
                break;
        }
    }

    private void ButtonAddBus_Click(object sender, EventArgs e) => CreateOblect(nameof(DrawningTramvaiBus));

    private void ButtonTramvaiBus_Click(object sender, EventArgs e) => CreateOblect(nameof(DrawningTramvai));

    private void CreateOblect(string type)
    {
        if (_company == null)
        {
            return;
        }

        Random random = new();
        DrawningTramvaiBus drawningTramvaiBus;
        switch (type)
        {
            case nameof(DrawningTramvaiBus):
                {
                    drawningTramvaiBus = new DrawningTramvaiBus(random.Next(100, 300), random.Next(1000, 3000), GetColor(random));
                    break;
                }
            case nameof(DrawningTramvai):
                {
                    drawningTramvaiBus = new DrawningTramvai(random.Next(100, 300), random.Next(1000, 3000),
                    GetColor(random),
                    GetColor(random),
                    GetColor(random),
                    Convert.ToBoolean(random.Next(0, 2)), Convert.ToBoolean(random.Next(0, 2)), Convert.ToBoolean(random.Next(0, 2)));
                    break;
                }
            default:
                return;
        }

        if (_company + drawningTramvaiBus)

        {
            MessageBox.Show("Обьект добавлен");
            pictureBox.Image = _company.Show();
        }
        else
        {
            MessageBox.Show("Не удалось добавить обьект");
        }
    }

    private static Color GetColor(Random random)
    {
        Color color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
        ColorDialog dialog = new();
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            color = dialog.Color;
        }

        return color;
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
        while (bus ==  null)
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
}
