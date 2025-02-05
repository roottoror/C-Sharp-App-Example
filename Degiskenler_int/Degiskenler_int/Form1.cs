namespace Degiskenler_int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Örnek:2 Sayının toplamını veren kodu yazınız:
            /*
            int Sayi1, Sayi2, Toplam;
            Sayi1 = 25;
            Sayi2 = 30;
            Toplam = Sayi1 + Sayi2;
            label1.Text = Toplam.ToString();
            */

            //Örnek: Karenin alanını ve çevresini hesaplayan programı yazınız:
            /*
            int kenar, alan, cevre;
            kenar = 10;
            alan = kenar * kenar;
            cevre = kenar * 4;
            label1.Text = "Alan:" + alan + " Cevre:" + cevre;
            */

            //Örnek: Kısa kenarı:10 Uzun kenarı:20 olan Dikdörtgenin alanını ve çevresini label'a yazdıran programı yazınız:
            /*
            int KısaKenar, UzunKenar, Alani, Cevre;
            KısaKenar = 10;
            UzunKenar = 20;
            Alani = KısaKenar * UzunKenar;
            Cevre = 2 * (KısaKenar+UzunKenar);
            label1.Text = "Alani:" + Alani + " Cevre:" + Cevre;
            */

            //Örnek: 3 sınav notu girilen öğrencinin ortalamasını hesaplayan kodu yazınız:
            int Sınav_1, Sınav_2, Sınav_3, Ortalama;
            Sınav_1 = 10;
            Sınav_2 = 10;
            Sınav_3 = 10;
            Ortalama = (Sınav_1 + Sınav_2 + Sınav_3) / 3;
            label1.Text = "Ortalaması: " + Ortalama;

            

        }
    }
}
