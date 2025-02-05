namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Sayac++;
            //label1.Text = Sayac.ToString();
            //if (Sayac == 5)
            //{

            //    this.BackColor = Color.Bisque;
            //}
            //if (Sayac == 10)
            //{

            //    this.BackColor = Color.Magenta;
            //    Sayac = 0;
            //}
            //2-4 arası kırmızı 4-6 arası yeşil 6-8 arası mor yanan kodu yazınız;

            Sayac++;
            label1.Text = Sayac.ToString();
            if(Sayac>2 && Sayac < 4)
            {
                this.BackColor = Color.Red;
            }
            else if (Sayac > 4 && Sayac < 6)
            {
                this.BackColor = Color.Green;
            }
            else if (Sayac > 6 && Sayac < 8)
            {
                this.BackColor = Color.Purple;
            }
            else if (Sayac==10)
            {
                Sayac = 1;
                
            }



        }
    }
}
