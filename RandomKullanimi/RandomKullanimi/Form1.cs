namespace RandomKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int Sayi_1,Sayi_2,Sayi_3;
            Sayi_1=random.Next(1, 9);
            Sayi_2=random.Next(1, 9);
            Sayi_3 = random.Next(1,9);

            label1.Text = Sayi_1.ToString();
            label2.Text = Sayi_2.ToString();
            label3.Text = Sayi_3.ToString();
        }
    }
}
