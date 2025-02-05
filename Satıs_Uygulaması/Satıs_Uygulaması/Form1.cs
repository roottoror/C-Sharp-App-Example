namespace Satıs_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet, toplam;
            misir = Convert.ToInt32(textBox1.Text);//textbox'a giirlen metni int'e çevirip değişkene aktarıyor.
            su = Convert.ToInt32(textBox2.Text);
            cay = Convert.ToInt32(textBox3.Text);
            bilet = Convert.ToInt32(textBox4.Text);
            toplam = misir * 100 + su * 50 + cay * 75 + bilet * 250;
            label9.Text = toplam.ToString() + "TL";
            kasatutar = kasatutar + toplam;
            label10.Text = kasatutar.ToString() + "TL";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
    }
}
