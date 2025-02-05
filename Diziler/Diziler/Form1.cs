namespace Diziler
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
             Diziler birbiriyle ilişkili veriler kümesidir.
            Örneğin:Renkler={mavi,sarı,kırmızı}
            Örneğin:ÇiftSayılar={0,2,4,6,8}
            Not:index= sıra ilk index=0 [i]
            
             */
            //string[] Kisiler = { "Ali","Ahmet","Mehmet" };
            //label1.Text = Kisiler[0];
            //char[] Harf = { 'a', 'b', 'c' };
            //label1.Text = Harf[0].ToString();

            //Dizi Elemanlarını listleme:
            //int[] Sayilar = { 1, 2, 3, 4, 5, 6 };
            //for(int i = 0; i < Sayilar.Length; i++)
            //{

            //    listBox1.Items.Add(Sayilar[i]);
            //}0,2,4,5,6,8,3,1,,
;
            //Tanımlanmış integer sayılardan çift olanları listbox'a yazdıran programı yazınız.
            int[] Sayilar_ = { 0, 2, 4, 5, 6, 8, 3, 1, 9 };
            for(int i = 0; i < Sayilar_.Length; i++)
            {
                if (Sayilar_[i] % 2 == 0)
                {
                    listBox1.Items.Add(Sayilar_[i]);
                }
            }
            
        }
    }
}
