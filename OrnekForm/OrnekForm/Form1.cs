namespace OrnekForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
              /*Klavyeden Adı,soyadı,yaşı(maskedtextbox),
                mesleği ve cinsiyeti girilen kişinin(Textbox'lara girilecek)
                burdaki değerleri değişkenlere atıp sonra onlarıda bir listbox'a yazdıran programı kodlayınız.
              */
            
            string Adi;
            string Soyadi;
            string Yası;
            string Cinsiyeti;
            string Meslegi;
            Adi = textBox1.Text;
            Soyadi = textBox2.Text;
            Yası = maskedTextBox1.Text;
            Cinsiyeti = textBox3.Text;
            Meslegi = textBox4.Text;

            listBox1.Items.Add("Adı: " + Adi+" "+"Soyadı: "+Soyadi+" "+"Yaşı: "+Yası+" "+"Cinsiyeti:"+" "+Cinsiyeti+" "+"Mesleği:"+" "+Meslegi);
        }
    }
}
