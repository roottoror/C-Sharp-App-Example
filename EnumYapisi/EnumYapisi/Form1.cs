namespace EnumYapisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum Sehirler { Edirne, Kırklareli, Tekirdağ, Çanakkale }
        private void button1_Click(object sender, EventArgs e)
        {
            int Plaka = Convert.ToInt32(textBox1.Text);
            Sehirler s;
            s = (Sehirler)Plaka;
            label1.Text = s.ToString();


        }
    }
}
