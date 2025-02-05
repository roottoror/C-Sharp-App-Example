namespace DegiskenlerDortIslem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Sayi1, Sayi2, Topla, Cıkar, Carp, Bol;
            Sayi1 = Convert.ToInt32(textBox1.Text);
            Sayi2 = Convert.ToInt32(textBox2.Text);
            Topla=Sayi1 + Sayi2;
            Cıkar = Sayi1 - Sayi2;
            Carp = Sayi1 * Sayi2;
            Bol = Sayi1 / Sayi2;
            MessageBox.Show("Toplam: " + Topla + "\n" + "Çıkarma:" + Cıkar + "\n" + "Çarpım:" + Carp + "\n" + "Bölüm:" + Bol);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
