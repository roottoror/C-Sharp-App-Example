namespace Degiskenler_Char
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
            char takim;
            takim = 'G';
            label1.Text = takim.ToString();
            */
            char ders;
            ders = Convert.ToChar(textBox1.Text);
            label1.Text=ders.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
