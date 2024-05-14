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

   
    public partial class Form2 : Form
    {

        
       
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter A = new StreamWriter(Application.StartupPath + "\\form\\" + "nots.txt");
           
            A.WriteLine(textBox1.Text + " " );

            A.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = File.OpenText(Application.StartupPath + "\\form\\" + "nots.txt");
            string metin;
            while ((metin = streamReader.ReadLine()) != null)

            {
                textBox1.Text = metin;

            }
            streamReader.Close();
        }
    }
}
