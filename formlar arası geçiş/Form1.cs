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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin" && textBox2.Text == "1234")
            {
                Form2 yeni = new Form2();
                yeni.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş !");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "admin";
            textBox2.Text = "1234";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                Form3 yeni = new Form3();
                yeni.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş !");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                Form4 yeni = new Form4();
                yeni.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş !");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                Form5 yeni = new Form5();
                yeni.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş !");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                Form6 yeni = new Form6();
                yeni.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş !");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                Form7 yeni = new Form7();
                yeni.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş !");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                Form9 yeni = new Form9();
                yeni.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş !");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
