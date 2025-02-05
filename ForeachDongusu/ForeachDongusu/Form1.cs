namespace ForeachDongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //foreach Döngüsü:
        /*
         foreach(1,2,3,4)
         1=Değişken türü.
         2=Değişken adı.
         3=in(içinden)
         4=Dizi adı.
         * */

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] Kisiler={"Ali","Ahmet","Mehmet","Ayşe","Fatma","Hilal"};
            //foreach(string k in Kisiler)
            //{
            //    listBox1.Items.Add(k);
            //}
            //            int toplam = 0; double Ortalama = 0;
            //           int[] Sinavlar = { 50, 60, 75, 85, 90, 40, 100 };
            //           foreach(int x in Sinavlar)
            //           {
            //                listBox1.Items.Add(x);
            //               toplam = toplam + x;
            //           }
            //           label1.Text = toplam.ToString();
            //           Ortalama = toplam / Sinavlar.Length;
            //            label2.Text = Ortalama.ToString();

            //Örnek:10 elemanlı bir dizide 4'e bölünen elemanları listeleyiniz.Bu dizide 4'e bölünen
            //kaç tane eleman olduğunu bulunuz.Ve Bu dizide 4'e bölünen sayıların toplamını bulan programı yazınız.
            int Toplam = 0; int Ortalama = 0;
            int[] Sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach(int s in Sayilar)
            {
                if (s % 4 == 0)
                {
                    listBox1.Items.Add(s);
                    Toplam = Toplam + s;

                }
                
                label1.Text = Toplam.ToString();
            }
        }
    }
}
