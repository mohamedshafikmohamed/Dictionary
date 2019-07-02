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

namespace WindowsFormsApplication18
{
    public partial class Form2 : Form
    {
        int x;
        public Form2(int i)
        {
            InitializeComponent();
            x = i;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                FileStream f = new FileStream("Dictionary.txt", FileMode.Append);
                StreamWriter w = new StreamWriter(f);
                string s1, s2;
                s1 = textBox1.Text;
                s2 = textBox2.Text;
                w.Write(s1 + ": ");
                w.WriteLine(s2);
                w.Close();
                
                MessageBox.Show("successfully add but if you  want to see it in dictionary click display all or back to tomain form and then write it and then translate !!!");
  
         
        }
        public void Set(string s)
        {
            textBox1.Text = s;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
