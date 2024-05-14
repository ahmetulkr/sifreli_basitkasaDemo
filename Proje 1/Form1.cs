using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proje_1
{
    public partial class Form1 : Form
    {

        int sifre = 2356;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox2.Text=="")
            {
                MessageBox.Show("Sifreyi giriniz");


            }

            else if (textBox2.Text=="1881")
            {
                MessageBox.Show("Tebrikler başarılı giriş yaptınız");

                this.Hide();
                Form2 frm = new Form2();
                frm.Show();
            }


            

        }




        private void button11_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
                       
           textBox2.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
       textBox2.Text += "2";
    }

        private void button3_Click(object sender, EventArgs e)
        {
       textBox2.Text += "3";
    }

        private void button4_Click(object sender, EventArgs e)
        {
        textBox2.Text += "4";
    }

        private void button5_Click(object sender, EventArgs e)
        {
        textBox2.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text += "0";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }
    }
}
