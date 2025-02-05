namespace Ogrenci_Sinav_Durumu_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Sınav_1=Convert.ToInt32(textBox1.Text);
            int Sınav_2=Convert.ToInt32(textBox2.Text);
            int Proje_Notu=Convert.ToInt32(textBox3.Text);
            int Sonuc;
        
            Sonuc = (Sınav_1 + Sınav_2 + Proje_Notu) / 3;
            if (Sonuc >= 60)
            {
                textBox4.Text = "Geçti: " + Sonuc.ToString();
            }
            else
            {
                textBox4.Text="Kaldı: "+Sonuc.ToString();
            }
        }
    }
}
