namespace SinifOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba rb = new Araba();
            rb.renk = "Mavi";
            rb.hiz = 150;
            rb.motor = 1200.50;
            rb.fiyat = 250000;
            rb.durum = 's';
            rb.YIL = -2010;
            rb.MARKA = "ford";
            rb.plaka = "22 HB 1996";
            rb.muayene = 2020;
            rb.sahip = "Ahmet";
            label1.Text=rb.renk;
            label2.Text = rb.hiz.ToString();
            label3.Text = rb.motor.ToString();
            label4.Text = rb.fiyat.ToString();
            label5.Text = rb.durum.ToString();
            label6.Text = rb.YIL.ToString();
            label7.Text = rb.MARKA.ToString();
            label8.Text = rb.muayene.ToString();
            label9.Text = rb.sahip;
            label10.Text = rb.plaka.ToString();
            pictureBox1.BackColor = Color.Azure;
        }
    }
}
