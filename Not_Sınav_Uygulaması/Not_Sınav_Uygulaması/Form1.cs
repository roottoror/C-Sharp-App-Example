namespace Not_Sınav_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Adı, Soyadı;
            int Sınav_1, Sınav_2, ProjeNotu,Sonuc;
            Adı = textBox1.Text;
            Soyadı = textBox2.Text;
            Sınav_1 = Convert.ToInt32(textBox3.Text);
            Sınav_2 = Convert.ToInt32(textBox4.Text);
            ProjeNotu = Convert.ToInt32(textBox5.Text);
            Sonuc=(Sınav_1+Sınav_2+ProjeNotu)/3;
            listBox1.Items.Add("Öğrencinin adı:" + Adı + " Öğrencinin Soyadı: " + Soyadı + " 1.Sınavı:" + Sınav_1 + " 2.Sınavı:" + Sınav_2 + " Proje Notu:" + ProjeNotu+" Sonucu:"+Sonuc); ;
            
        }
    }
}
