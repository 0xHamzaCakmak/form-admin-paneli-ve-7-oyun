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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\reela\OneDrive\Masaüstü\ankaranın bağları.mp3";
            pictureBox1.ImageLocation = @"C:\Users\reela\OneDrive\Pictures\Ekran Görüntüleri\2016-05-20.png";
        }
    }
}
