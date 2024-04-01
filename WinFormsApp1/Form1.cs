namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int en_start { get; set; }
        int uzunluq_start { get; set; }
        int en_end { get; set; }
        int uzunluq_end { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void M_Down(object sender, MouseEventArgs e)
        {
            en_start = (int)e.X;
            uzunluq_start = (int)e.Y;
            button1.Location = e.Location;
        }

        private void M_Up(object sender, MouseEventArgs e)
        {
            en_end = (int)e.X;
            uzunluq_end = (int)e.Y;

            button1.Width = Math.Abs(en_end - en_start);
            button1.Height = Math.Abs(uzunluq_end - uzunluq_start);
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}