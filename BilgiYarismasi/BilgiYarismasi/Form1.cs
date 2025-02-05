namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int SoruNo = 0, Dogru = 0, Yanlıs = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            SoruNo = SoruNo + 1;
            label4.Text = SoruNo.ToString();
            if (SoruNo == 1)
            {
                richTextBox1.Text = "Hangi sayı çift sayıdır?";
                button1.Text = "1";
                button2.Text = "9";
                button3.Text = "3";
                button4.Text = "2";
                label7.Text = "2";
            }
            if (SoruNo == 2)
            {
                richTextBox1.Text = "Hangi sayı tek sayıdır?";
                button1.Text = "4";
                button2.Text = "3";
                button3.Text = "6";
                button4.Text = "2";
                label7.Text = "3";

            }
            if (SoruNo == 3)
            {
                richTextBox1.Text = "Hangi sayı doğal sayıdır?";
                button1.Text = "0";
                button2.Text = "-1";
                button3.Text = "-2";
                button4.Text = "-3";
                label7.Text = "0";
                button5.Text = "Sonuçlar";
            }
            if (SoruNo == 4)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                MessageBox.Show("Doğru:"+Dogru+ "\n"+"Yanlış:"+Yanlıs);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            label8.Text = button1.Text;
            if (label7.Text == label8.Text)
            {
                Dogru++;
                label5.Text = Dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                Yanlıs++;
                label6.Text = Yanlıs.ToString();
                pictureBox1.Visible = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text = button2.Text;
            if (label7.Text == label8.Text)
            {
                Dogru++;
                label5.Text = Dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                Yanlıs++;
                label6.Text = Yanlıs.ToString();
                pictureBox1.Visible = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text = button3.Text;
            if (label7.Text == label8.Text)
            {
                Dogru++;
                label5.Text = Dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                Yanlıs++;
                label6.Text = Yanlıs.ToString();
                pictureBox1.Visible = true;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text = button4.Text;
            if (label7.Text == label8.Text)
            {
                Dogru++;
                label5.Text = Dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                Yanlıs++;
                label6.Text = Yanlıs.ToString();
                pictureBox1.Visible = true;

            }
        }
    }
}
