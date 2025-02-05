namespace KupHesaplaUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int KupAlma(int Sayi1)
        {
            return Sayi1 * Sayi1 * Sayi1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int S_1 = Convert.ToInt32(textBox1.Text);
            int Sonuc = KupAlma(S_1);
            textBox2.Text = Sonuc.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
