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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Mavi")
            {
                label4.Text = textBox1.Text +" " +comboBox1.Text+"  Rengi =  Mutluluğun ve Pozitifliğin rengidir :)";
                button2.BackColor = Color.Blue;
            }
            if (comboBox1.Text == "Sarı")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + "  Rengi=  İyimserliğin Rengidir :)";
                button2.BackColor = Color.Yellow;
            }
            if (comboBox1.Text == "Yeşil")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + "  Rengi=  Bereketin Rengidir :)";
                button2.BackColor = Color.Green;
            }
            if (comboBox1.Text == "Siyah")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + "  Rengi=  Karamsarlılığın Rengidir:)";
                button2.BackColor = Color.Black;
            }
            if (comboBox1.Text == "Kırmızı")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + "  Rengi=  Tutkunun Rengidir :)";
                button2.BackColor = Color.Red;
            }
            if (comboBox1.Text == "Beyaz")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + "  Rengi=  Temizliğin Rengidir :)";
                button2.BackColor = Color.White;
            }
        }
    }
}
