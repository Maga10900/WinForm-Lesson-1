namespace WinFormsApp2
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }



        private void MHower(object sender, EventArgs e)
        {
            int a = ClientSize.Width;
            int b = ClientSize.Height;
            int c = Random.Shared.Next(0, a) - button1.Width;
            int d = Random.Shared.Next(0, b) - button1.Height;
            button1.Location = new Point(c, d);
        }

        private void Window_Load(object sender, EventArgs e)
        {

        }
    }
}