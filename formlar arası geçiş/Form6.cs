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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double turkce, matematik, sosyal, fen;
            double ygs1, ygs2, ygs3, ygs4, ygs5, ygs6;
            
            turkce = Convert.ToDouble(textBox1.Text);
            sosyal = Convert.ToDouble(textBox2.Text);
            matematik = Convert.ToDouble(textBox3.Text);
            fen = Convert.ToDouble(textBox4.Text);
            ygs1 = 100.160 + (turkce * 1.999) + (sosyal * 1) + (matematik * 3.999) + (fen * 2.998);
            labelygs1.Text = ygs1.ToString();

            ygs2 = 100.160 + (turkce * 1.999) + (sosyal * 1) + (matematik * 2.999) + (fen * 3.998);
            labelygs2.Text = ygs2.ToString();

            ygs3 = 100.160 + (turkce * 3.998) + (sosyal * 2.999) + (matematik * 1.999) + (fen * 1);
            labelygs3.Text = ygs3.ToString();

            ygs4 = 100.160 + (turkce * 2.999) + (sosyal * 3.998) + (matematik * 1.999) + (fen * 1);
            labelygs4.Text = ygs4.ToString();

            ygs5 = 100.120 + (turkce * 3.998) + (sosyal * 2.999) + (matematik * 1.999) + (fen * 1);
            labelygs5.Text = ygs5.ToString();

            ygs6 = 100.120 + (turkce *3.299) + (sosyal * 1) + (matematik * 3.699) + (fen * 1.999);
            labelygs6.Text = ygs6.ToString();

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
