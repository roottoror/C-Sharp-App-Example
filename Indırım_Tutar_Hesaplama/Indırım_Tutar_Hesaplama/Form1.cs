namespace Indırım_Tutar_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adet=Convert.ToInt32(textBox1.Text);
            double tutar;
            int fiyat = 8;
            if(adet>0 && adet < 20)
            {
                tutar = (adet * fiyat) - (adet * fiyat * 0.20);
                label3.Text = tutar + "TL";
            }
            if (adet >= 21 && adet <= 40)
            {
                tutar = (adet * fiyat) - (adet * fiyat * 0.40);
                label3.Text = tutar + "TL";
            }
            if (adet >= 41)
            {
                tutar = (adet * fiyat) - (adet * fiyat * 0.50);
                label3.Text = tutar + "TL";
            }

        }
    }
}
