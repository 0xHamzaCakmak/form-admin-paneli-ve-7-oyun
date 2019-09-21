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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Random r = new Random();
        int gspuan = 0;
        int fbpuan = 0;
        int bjkpuan = 0;
        int tspuan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int a = r.Next(0, 5);
            int b = r.Next(0, 5);
            int c = r.Next(0, 5);
            int d = r.Next(0, 5);

            label4.Text = a.ToString();
            label5.Text = b.ToString();
            label8.Text = c.ToString();
            label6.Text = d.ToString();
            if(Convert.ToInt32(label4.Text)> Convert.ToInt32(label5.Text))
            {
                gspuan += 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label4.Text) < Convert.ToInt32(label5.Text))
            {
                fbpuan += 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label4.Text) == Convert.ToInt32(label5.Text))
            {
                gspuan += 1;
                fbpuan += 1;
                labelgspuan.Text = gspuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label8.Text) > Convert.ToInt32(label6.Text))
            {
                bjkpuan += 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label8.Text) < Convert.ToInt32(label6.Text))
            {
                tspuan += 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label8.Text) == Convert.ToInt32(label6.Text))
            {
                bjkpuan += 1;
                tspuan += 1;
                labelbjkpuan.Text = bjkpuan.ToString();
                labeltspuan.Text = tspuan.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            int a = r.Next(0, 5);
            int b = r.Next(0, 5);
            int c = r.Next(0, 5);
            int d = r.Next(0, 5);

            label11.Text = a.ToString();
            label12.Text = b.ToString();
            label15.Text = c.ToString();
            label16.Text = d.ToString();
            if (Convert.ToInt32(label11.Text) > Convert.ToInt32(label12.Text))
            {
                gspuan += 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label11.Text) < Convert.ToInt32(label12.Text))
            {
                bjkpuan += 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label11.Text) == Convert.ToInt32(label12.Text))
            {
                gspuan += 1;
                bjkpuan += 1;
                labelgspuan.Text = gspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label15.Text) > Convert.ToInt32(label16.Text))
            {
                fbpuan += 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label15.Text) < Convert.ToInt32(label16.Text))
            {
                tspuan += 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label15.Text) == Convert.ToInt32(label16.Text))
            {
                fbpuan += 1;
                tspuan += 1;
                labelfbpuan.Text = fbpuan.ToString();
                labeltspuan.Text = tspuan.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Visible = true;
            int a = r.Next(0, 5);
            int b = r.Next(0, 5);
            int c = r.Next(0, 5);
            int d = r.Next(0, 5);

            label25.Text = a.ToString();
            label26.Text = b.ToString();
            label29.Text = c.ToString();
            label30.Text = d.ToString();
            if (Convert.ToInt32(label25.Text) > Convert.ToInt32(label26.Text))
            {
                fbpuan += 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label25.Text) < Convert.ToInt32(label26.Text))
            {
                bjkpuan += 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label25.Text) == Convert.ToInt32(label26.Text))
            {
                fbpuan += 1;
                bjkpuan += 1;
                labelfbpuan.Text = gspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label29.Text) > Convert.ToInt32(label30.Text))
            {
                tspuan += 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label29.Text) < Convert.ToInt32(label30.Text))
            {
                gspuan += 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label29.Text) == Convert.ToInt32(label30.Text))
            {
                gspuan += 1;
                tspuan += 1;
                labelgspuan.Text = gspuan.ToString();
                labeltspuan.Text = tspuan.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelbjkpuan.Text) && Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labeltspuan.Text)) 
            {
                pictureBox1.ImageLocation = @"‪C:\Users\reela\OneDrive\Masaüstü\c# resim\gs.jpg";
            }
            if (Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelbjkpuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelgspuan.Text)) 
            {
                pictureBox1.ImageLocation = @"‪C:\Users\reela\OneDrive\Masaüstü\c# resim\ts.jpg";
            }
            if (Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelbjkpuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labeltspuan.Text)) 
            {
                pictureBox1.ImageLocation = @"‪C:\Users\reela\OneDrive\Masaüstü\c# resim\fb.jpg";
            }
            if (Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labeltspuan.Text)) 
            {
                pictureBox1.ImageLocation = @"‪C:\Users\reela\OneDrive\Masaüstü\c# resim\bjk.jpg";
            }
        }
    }
}
