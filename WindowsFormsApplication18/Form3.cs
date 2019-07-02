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
    public partial class Form3 : Form
    {
        public Form3(int i2)
        {
            
            InitializeComponent();
         
            if (i2 == 0)
            {
                FileStream f = new FileStream("Dictionary.txt", FileMode.Open);
                StreamReader r = new StreamReader(f);
                while (r.Peek() != -1)
                {

                    string s = r.ReadLine();
                    string[] s2 = s.Split(':');

                    dataGridView1.Rows.Add(s2);

                }

                r.Close();
            }
            else {

                FileStream f = new FileStream("Arabic dictionary.txt", FileMode.Open);
                StreamReader r = new StreamReader(f);
                while (r.Peek() != -1)
                {

                    string s = r.ReadLine();
                    string[] s2 = s.Split(':');

                    dataGridView1.Rows.Add(s2);

                }

                r.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

      
    }
}
