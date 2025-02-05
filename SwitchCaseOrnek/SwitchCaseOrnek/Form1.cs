namespace SwitchCaseOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Klavyeden girilen sembole göre iki sayı arasında işlem yapan programı yazınız.
            double Sayi_1 = Convert.ToDouble(textBox1.Text);
            double Sayi_2 = Convert.ToDouble(textBox2.Text);
            string Islem_Operator = textBox3.Text;

            switch (Islem_Operator)
            {
                case "+": textBox4.Text = (Sayi_1 + Sayi_2).ToString(); break;
                case "-": textBox4.Text = (Sayi_1 - Sayi_2).ToString(); break;
                case "*": textBox4.Text = (Sayi_1 * Sayi_2).ToString(); break;
                case "/": textBox4.Text = (Sayi_1 / Sayi_2).ToString(); break;
                default: MessageBox.Show("Geçersiz Sembol Lütfen Tekrar Deneyiniz:"); break;
            }
        }

      
    }
}
