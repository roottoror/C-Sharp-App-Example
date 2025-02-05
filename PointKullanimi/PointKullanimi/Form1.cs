namespace PointKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point konum = new Point();
            konum.X = 25;
            konum.Y = 25;
            pictureBox1.Location = konum;
        }
    }
}
