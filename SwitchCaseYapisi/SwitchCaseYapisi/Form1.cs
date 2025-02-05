namespace SwitchCaseYapisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Girilen Sayıya göre yılın ayını veren Programı yazınız. Örneğin 1 sayısı Ocak ayını verir.
            int AySayisi=Convert.ToInt32(textBox1.Text);
            switch (AySayisi)
            {
                case 1:label2.Text = "Ocak"; break;
                case 2:label2.Text = "Şubat";break;
                case 3: label2.Text = "Mart"; break;
                case 4: label2.Text = "Nisan"; break;
                case 5: label2.Text = "Mayı"; break;
                case 6: label2.Text = "Haziran"; break;
                case 7: label2.Text = "Temmuz"; break;
                case 8: label2.Text = "Ağustos"; break;
                case 9: label2.Text = "Eylül"; break;
                case 10: label2.Text = "Ekim"; break;
                case 11: label2.Text = "Kasım"; break;
                case 12: label2.Text = "Aralık"; break;
                default:label2.Text = "Hatalı Ay"; break;
            }
           



        }
    }
}
