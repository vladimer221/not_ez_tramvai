using notez.Drawnings;
using notez.MovementStategy;

namespace notez
{
    public partial class Formbus : Form
    {

        private DrawningTramvaiBus? _drawningTramvaiBus;

        private AbstractStategy? _strategy;

        public DrawningTramvaiBus SetCar
        {
            set 
            {
                _drawningTramvaiBus = value;
                _drawningTramvaiBus.SetPictureSize(pictureBoxBus.Width, pictureBoxBus.Height);
                comboBoxStrategy.Enabled = true;
                _strategy = null;
                Draw();
            }
        }

        public Formbus()
        {
            InitializeComponent();
            _strategy = null;
        }

        private void Draw()
        {
            if (_drawningTramvaiBus == null)
            {
                return;
            }

            Bitmap bmp = new(pictureBoxBus.Width, pictureBoxBus.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _drawningTramvaiBus.DrawTransport(gr);
            pictureBoxBus.Image = bmp;
        }

        private void ButtonMove_Click(object sender, EventArgs e)
        {
            if (_drawningTramvaiBus == null)
            {
                return;
            }

            string name = ((Button)sender)?.Name ?? string.Empty;
            bool result = false;
            switch (name)
            {
                case "buttonUp":
                    result = _drawningTramvaiBus.MoveTransport(DirectionType.Up);
                    break;
                case "buttonDown":
                    result = _drawningTramvaiBus.MoveTransport(DirectionType.Down);
                    break;
                case "buttonLeft":
                    result = _drawningTramvaiBus.MoveTransport(DirectionType.Left);
                    break;
                case "buttonRight":
                    result = _drawningTramvaiBus.MoveTransport(DirectionType.Right);
                    break;
            }

            if (result)
            {
                Draw();
            }
        }

        private void buttonStrategyStep_Click(object sender, EventArgs e)
        {
            if (_drawningTramvaiBus == null)
            {
                return;
            }
            if (comboBoxStrategy.Enabled)
            {
                _strategy = comboBoxStrategy.SelectedIndex switch
                {
                    0 => new MoveToCenter(),
                    1 => new MoveToBorder(),
                    _ => null,
                };
                if (_strategy == null)
                {
                    return;
                }
                _strategy.SetData(new MoveableBus(_drawningTramvaiBus), pictureBoxBus.Width, pictureBoxBus.Height);
            }
            if (_strategy == null)
            {
                return;
            }
            comboBoxStrategy.Enabled = false;
            _strategy.MakeStep();
            Draw();

            if (_strategy.GetStatus() == StrategyStatus.Finish)
            {
                comboBoxStrategy.Enabled = true;
                _strategy = null;
            }


        }

    }
}

