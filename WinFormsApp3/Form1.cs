using System.Security.Cryptography;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeRegion_A(object sender, EventArgs e)
        {
            if(ChangeRegion_Btn.Text == "Baku")
            {
                ChangeRegion_Btn.Text = "London";
                Saat.Text = DateTime.Now.AddHours(3).ToString();
                Sekil.Image = Properties.Resources.GettyImages_1047502134_ebf7496b41e047759046e17b91f57679;
            }
            else if(ChangeRegion_Btn.Text == "London")
            {
                ChangeRegion_Btn.Text = "Baku";
                Saat.Text = DateTime.Now.ToString();
                Sekil.Image = Properties.Resources.Baku;
            }
        }
    }
}
