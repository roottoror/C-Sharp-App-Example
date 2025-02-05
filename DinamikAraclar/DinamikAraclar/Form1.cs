namespace DinamikAraclar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn=new Button();
            Point btnkonum= new Point(20,20);
            btn.Location = btnkonum;
            btn.Name = "Button1";
            btn.Text = "Tıkla";
            btn.Height = 50;
            btn.Width = 75;
            btn.BackColor = Color.Green;
            this.Controls.Add(btn);

            Label lbl=new Label();
            Point lblkonum= new Point(20,25);
            lbl.Location = lblkonum;
            lbl.Name = "Label1";
            lbl.Text = "Merhaba";
            lbl.Height = 50;
            lbl.Width = 50;
            lbl.BackColor = Color.Red;
            this.Controls.Add(lbl);

            for(int i = 1; i <= 5; i++)
            {
                TextBox txt=new TextBox();
                Point txtkonum=new Point(350,i*30);
                txt.Location = txtkonum;
                txt.Name = "Textbox" + i;
                txt.Text = i.ToString();
                this.Controls.Add(txt);
            }
        }
    }
}
