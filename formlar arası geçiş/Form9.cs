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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://www.trt.net.tr/anasayfa/canli.aspx?y=radyo&k=trtturku";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://dinleradyo.web.tr/adana/power-fm";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://dinleradyo.web.tr/stations/power-turk";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.mgm.gov.tr/tahmin/il-ve-ilceler.aspx?il=SIVAS");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 bilet = new Form8();
            bilet.Show();
            this.Hide();
        }
    }
}
