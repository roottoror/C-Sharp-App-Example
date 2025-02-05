namespace Karar_Yapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            string Ad = textBox1.Text;
            if (Ad == "Haydar")
            {
                label1.Text = "Hoşgeldiniz";
            }
            else
            {
                label1.Text = "Hatalı Kişi";
            }
            */

            //Klavyeden Girilen 5 sayısının doğru olup olmadığını kontrol eden programı yazınızz.
            /*
            int Sayi = Convert.ToInt32(textBox1.Text);
            if (Sayi == 5)
            {
                label1.Text = "Doğru Giriş";
            }
            else
            {
                label1.Text = "Yanlış Giriş";
            }
            */
            //Klavyeden girilen sayının tek mi çift mi olan programı yazınız.
            
            int Sayi=Convert.ToInt32(textBox1.Text);
            if (Sayi % 2 == 0)
            {
                label1.Text = "Sayi çift";
            }
            else
            {
                label1.Text = "Sayi tek";
            }


        }
    }
}
