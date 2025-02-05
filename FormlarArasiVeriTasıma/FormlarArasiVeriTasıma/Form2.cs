using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasiVeriTasıma
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string Mesaj;
        public string Mesaj2;
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = Mesaj;
            label2.Text = Mesaj2;
        }
    }
}
