namespace Degiskenler_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Textbox'tan aldığım veriyi label'a yazdıran program.
            string sehir;
            sehir = textBox1.Text;
            label1.Text = sehir;

            /*Klavyeden Adı,soyadı,yaşı(maskedtextbox),
             mesleği ve cinsiyeti girilen kişinin(Textbox'lara girilecek)
            burdaki değerleri değişkenlere atıp sonra onlarıda bir listbox'a yazdıran programı kodlayınız.
            */

        }
    }
}
