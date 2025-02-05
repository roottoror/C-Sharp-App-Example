namespace FaktoriyelOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Faktoriyel = 1;
            int Sayi=Convert.ToInt32(textBox1.Text);
            for(int i = 1; i <= Sayi; i++)
            {
                Faktoriyel=i*Faktoriyel;
                textBox2.Text = Convert.ToString(Faktoriyel);
            }
            if (Sayi == 0)
            {
                Faktoriyel = 1;
                textBox2.Text = Convert.ToString(Faktoriyel);
            }
        }
    }
}
