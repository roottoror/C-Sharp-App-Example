namespace DijitalSaat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Saat = 0;
        int Dakika = 0;
        int Saniye = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Saniye++;
            label1.Text = Saniye.ToString();
            if (Saniye == 60)
            {
                Dakika++;
                label2.Text = Dakika.ToString();
                Saniye = 0;
                if (Dakika == 5)
                {
                    Saat = Saat + 1;
                    label3.Text = Saat.ToString();
                    Dakika = 0;
                }
            }
        }
    }
}
