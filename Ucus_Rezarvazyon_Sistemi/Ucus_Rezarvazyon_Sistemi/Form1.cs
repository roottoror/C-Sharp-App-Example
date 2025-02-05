namespace Ucus_Rezarvazyon_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Nereden: " + comboBox1.Text + " Nereye: " + comboBox2.Text + " Tarih " + dateTimePicker1.Text + " Saat: " + maskedTextBox1.Text + " YolcuAdSoyad: " + textBox1.Text + " TC: " + maskedTextBox3.Text + " Telefon: " + maskedTextBox4.Text);
            MessageBox.Show("Yolcu Kaydı Yapılmıştır.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
            

        }
    }
}
