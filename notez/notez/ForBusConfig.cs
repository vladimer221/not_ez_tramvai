using notez.Drawnings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notez;

public partial class ForBusConfig : Form
{
    private DrawningTramvaiBus _bus;

    private Color BodyColor = Color.White;

    private Color AdditionalColor = Color.Black;

    private Color additionalBodyColor = Color.Black;

    private bool TramvaiBus;

    private event BusDelegate? BusDelegate;
    public ForBusConfig()
    {
        InitializeComponent();
    }

    public void addEvent(BusDelegate busDelegate)
    {
        BusDelegate += busDelegate;
    }

    private void DrawObject()
    {
        Bitmap bmp = new(pictureBoxObject.Width, pictureBoxObject.Height);
        Graphics gr = Graphics.FromImage(bmp);
        _bus?.SetPictureSize(pictureBoxObject.Width, pictureBoxObject.Height);
        _bus?.SetPosition(5, 5);
        _bus?.DrawTransport(gr);
        pictureBoxObject.Image = bmp;
    }

    private void LabelObject_MouseDown(object sender, MouseEventArgs e)
    {
        (sender as Label)?.DoDragDrop((sender as Label)?.Name ?? string.Empty, DragDropEffects.Move | DragDropEffects.Copy);
    }

    private void PanelOblect_DragEnter(object sender, DragEventArgs e)
    {
        e.Effect = e.Data?.GetDataPresent(DataFormats.Text) ?? false ? DragDropEffects.Copy : DragDropEffects.None;
    }

    private void PanelObject_DragDrop(object sender, DragEventArgs e)
    {
        switch (e.Data?.GetData(DataFormats.Text)?.ToString())
        {
            case "labelSimpleObject":
                _bus = new DrawningTramvaiBus((int)numericUpDownSpeed.Value,
                (double)numericUpDownWeight.Value, BodyColor);
                TramvaiBus = false;
                break;
            case "labelModifiedObject":
                _bus = new
                DrawningTramvai((int)numericUpDownSpeed.Value, (double)numericUpDownWeight.Value,
                BodyColor,
                AdditionalColor, additionalBodyColor, checkBoxLine.Checked,
                checkBoxSecondDoor.Checked);
                TramvaiBus = true;
                break;
        }
        DrawObject();
    }

    private void Panel_MouseDown(object sender, MouseEventArgs e)
    {
        (sender as Panel)?.DoDragDrop((sender as Panel)?.BackColor.Name ?? string.Empty, DragDropEffects.Move | DragDropEffects.Copy);
    }

    private void LabelColor_DragDrop(object sender, DragEventArgs e)
    {
        List<string> colorList = new() { "Red", "Green", "Blue", "Black", "White", "Gray", "Yellow", "Purple" };
        if (_bus == null)
        {
            return;
        }
        switch ((sender as Label)?.Text)
        {
            case "Левый":
                {
                    BodyColor = Color.FromName(e.Data?.GetData(DataFormats.Text)?.ToString());
                    break;
                }
            case "Центр":
                {
                    AdditionalColor = Color.FromName(e.Data?.GetData(DataFormats.Text)?.ToString());
                    break;
                }
            case "Правый":
                {
                    additionalBodyColor = Color.FromName(e.Data?.GetData(DataFormats.Text)?.ToString());
                    break;
                }

        }

        string labelText = e.Data?.GetData(DataFormats.Text)?.ToString();
        if (colorList.Contains(labelText))
        {
            if (TramvaiBus)
            {
                _bus = new
            DrawningTramvai((int)numericUpDownSpeed.Value, (double)numericUpDownWeight.Value,
                BodyColor,
                AdditionalColor, additionalBodyColor, checkBoxLine.Checked, checkBoxSecondDoor.Checked);
            }
            else
            {
                _bus = new DrawningTramvaiBus((int)numericUpDownSpeed.Value, (double)numericUpDownWeight.Value, BodyColor);
            }
            DrawObject();
        }

    }


    private void ButtonAdd_Click(object sender, EventArgs e)
    {
        if (_bus != null)
        {
            BusDelegate?.Invoke(_bus);
            Close();
        }
    }


    private void LabelColor_DragEnter(object sender, DragEventArgs e)
    {
        e.Effect = e.Data?.GetDataPresent(DataFormats.Text) ?? false ? DragDropEffects.Copy : DragDropEffects.None;
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();
}

