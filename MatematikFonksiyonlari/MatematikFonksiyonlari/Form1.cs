namespace MatematikFonksiyonlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abs:Mutlak Değer
            //Ceil: Üste Yuvarlama
            //Floor:Alta yuvarlama
            //Pow:Üs alma
            //Sqrt:Karekök alma
            double sayi;
            sayi=Convert.ToDouble(textBox1.Text);
            label2.Text = Math.Abs(sayi).ToString();
           
        }
    }
}
