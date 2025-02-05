namespace DoWhileDongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            do
            {
                listBox1.Items.Add("Merhaba");
                i++;

            }
            while (i <= 10);
            
        }
    }
}
