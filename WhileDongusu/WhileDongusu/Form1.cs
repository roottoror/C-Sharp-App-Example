namespace WhileDongusu
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
            while (i < 5) {
            
                listBox1.Items.Add("Merhaba D�nya");
                listBox2.Items.Add(i);
                i++;
            }
            int j = 1;
            int toplam = 0;
            while (j<=5)
            {
                toplam = toplam + j;
                j++;
            }
            MessageBox.Show(toplam.ToString());
        }
    }
}
