using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formlar_arası_geçiş
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int sayi1 = r.Next(1,7);
            int sayi2 = r.Next(1, 7);
            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();
        }
    }
}
