namespace Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
        private void renklendir()
        {
            textBox1.BackColor = Color.Green;
            textBox2.BackColor = Color.SaddleBrown;
            textBox3.BackColor = Color.Firebrick;
            textBox4.BackColor = Color.Tan;
        }
        private void VeriYaz()
        {
            textBox1.Text = "George";
            textBox2.Text = "Forest";
            textBox3.Text = "Texsas";
            textBox4.Text = "Kovboy";
            textBox1.Focus();
        }
        private void RenkTemizle()
        {
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
            RenkTemizle();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            renklendir();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            VeriYaz();
        }
    }
}
