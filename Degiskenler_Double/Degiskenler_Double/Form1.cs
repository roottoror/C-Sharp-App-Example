using System.Runtime.Intrinsics.Arm;

namespace Degiskenler_Double
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            double s1, s2, s3, ort;
            s1 = 15;
            s2 = 24;
            s3 = 48;
            ort = (s1 + s2 + s3) / 3;
            label1.Text = ort.ToString("0.00");
            */

            //Ornek:Textbox'a girilen değeri label'a yazdıran kodu yazınız.
            double Sayi = Convert.ToDouble(textBox1.Text);
            label1.Text=Sayi.ToString();

            
        }
    }
}
