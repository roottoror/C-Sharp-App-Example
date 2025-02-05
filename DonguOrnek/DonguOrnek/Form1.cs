namespace DonguOrnek
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
            for(int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 && i%7==0)
                {
                    listBox1.Items.Add(i);
                }
            */

            //Klavyeden girilen sayıyı listboxta listeyen kodu yazınız.
            
            /*
            int Sayi = Convert.ToInt32(textBox1.Text);
            for(int i=1; i <= Sayi; i++)
            {
                listBox1.Items.Add(i);
            }
            */
            //Klavyeden girilen sayının tam bölenlerini veren kodu yazınız.
            int Sayi=Convert.ToInt32(textBox1.Text);
            for (int i=1;i<=Sayi;i++)
            {
                if (Sayi % i == 0)
                {
                    listBox1.Items.Add(i);
                }

            }
            
        }
    }
}
