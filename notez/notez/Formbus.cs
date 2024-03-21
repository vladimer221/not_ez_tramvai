using notez.Drawnings;
using notez.MovementStategy;

namespace notez
{
    public partial class Formbus : Form
    {

        private DrawningTramvaiBus? _drawningTramvaiBus;

        private AbstractStategy? _strategy;

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

        private void CreateOblect(string type)
        {

            Random random = new();
            switch (type)
            {
                case nameof(DrawningTramvaiBus):
                    {
                        _drawningTramvaiBus = new DrawningTramvaiBus(random.Next(100, 300), random.Next(1000, 3000),
                        Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));
                        break;
                    }
                case nameof(DrawningTramvai):
                    {
                        _drawningTramvaiBus = new DrawningTramvai(random.Next(100, 300), random.Next(1000, 3000),
                        Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)),
                        Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)),
                        Convert.ToBoolean(random.Next(0, 2)), Convert.ToBoolean(random.Next(0, 2)), Convert.ToBoolean(random.Next(0, 2)));
                        break;
                    }
                default:
                    return;
            }
            _drawningTramvaiBus.SetPictureSize(pictureBoxBus.Width, pictureBoxBus.Height);
            _drawningTramvaiBus.SetPosition(random.Next(10, 100), random.Next(10, 100));
            _strategy = null;
            comboBoxStrategy.Enabled = true;
            Draw();
        }

        private void ButtonCreateCar_Click(object sender, EventArgs e) => CreateOblect(nameof(DrawningTramvai));

        private void ButtonCreate_Click(object sender, EventArgs e) => CreateOblect(nameof(DrawningTramvaiBus));
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

