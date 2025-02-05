namespace KlavyeGirisiOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Not:int dönüşüm türleri:toint16,toint32(En çok tercih edilen),toint64 gibi
            // Yazdır Butonuna bastığımda textbox'a girilen değeri label'a yazdıran program:
            /*
            int Sayi;
            Sayi = Convert.ToInt32(textBox1.Text);//textBox1.text'ten gelen metni integer'a çevirdi.
            label2.Text = Sayi.ToString();
            */

            //Textbox'a girilen sayının küpünü aldıran ve label'a gösteren programı yazınız.
            int Sayi;
            Sayi = Convert.ToInt32(textBox1.Text);
            Sayi = Sayi * Sayi * Sayi;
            label2.Text=Sayi.ToString();
                


            
        }
    }
}
