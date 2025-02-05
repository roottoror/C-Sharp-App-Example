namespace Return_Metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Carp(int Sayi1,int Sayi2,int Sayi3)
        {
            
            return Sayi1 * Sayi2 * Sayi3;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int Sayi1=Convert.ToInt32(textBox1.Text);
            int Sayi2=Convert.ToInt32(textBox2.Text);
            int Sayi3=Convert.ToInt32(textBox3.Text);
            int Sonuc = Carp(Sayi1, Sayi2, Sayi3);
            textBox4.Text = Sonuc.ToString();

        }
    }
}
