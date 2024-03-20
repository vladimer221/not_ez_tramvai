namespace notez
{
    public partial class Formbus : Form
    {

        private DrawningTramvai? _drawningTramvai;

        public Formbus()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            if (_drawningTramvai == null)
            {
                return;
            }

            Bitmap bmp = new(pictureBoxBus.Width, pictureBoxBus.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _drawningTramvai.DrawTransport(gr);
            pictureBoxBus.Image = bmp;
        }



        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            _drawningTramvai = new DrawningTramvai();
            _drawningTramvai.Init(random.Next(100, 300), random.Next(1000, 3000),
                Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)),
                Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)),
                Convert.ToBoolean(random.Next(0, 2)), Convert.ToBoolean(random.Next(0, 2)), Convert.ToBoolean(random.Next(0, 2)));
            _drawningTramvai.SetPictureSize(pictureBoxBus.Width, pictureBoxBus.Height);
            _drawningTramvai.SetPosition(random.Next(10, 100), random.Next(10, 100));
            Draw();

        }
        private void ButtonMove_Click(object sender, EventArgs e)
        {
            if (_drawningTramvai == null)
            {
                return;
            }

            string name = ((Button)sender)?.Name ?? string.Empty;
            bool result = false;
            switch (name)
            {
                case "buttonUp":
                    result = _drawningTramvai.MoveTransport(DirectionType.Up);
                    break;
                case "buttonDown":
                    result = _drawningTramvai.MoveTransport(DirectionType.Down);
                    break;
                case "buttonLeft":
                    result = _drawningTramvai.MoveTransport(DirectionType.Left);
                    break;
                case "buttonRight":
                    result = _drawningTramvai.MoveTransport(DirectionType.Right);
                    break;
            }

            if (result)
            {
                Draw();
            }
        }

        

        
    }
}

