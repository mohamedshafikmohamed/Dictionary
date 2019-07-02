using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.IO;
using System.Threading;
using System.Speech;
using System.Speech.Synthesis;
namespace WindowsFormsApplication18
{
    public partial class Form1 : Form
    {public int Count=0;
    Dictionary<string, string> dictionary = new Dictionary<string, string>();
    SpeechSynthesizer reader = new SpeechSynthesizer();
        public Form1()
        {
           
            InitializeComponent();
            if (Count == 0)
            {

                FileStream f = new FileStream("Dictionary.txt", FileMode.Open);
                StreamReader r = new StreamReader(f);
                while (r.Peek() != -1)
                {

                    string s = r.ReadLine();
                    string[] s2 = s.Split(':');
                    dictionary[s2[0]] = s2[1];



                }
                Count++;
                r.Close();
            }
            
            
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {string word=search.Text.ToLower();
          
           
           
           if(dictionary.ContainsKey(word))
           {
               richTextBox1.Text = dictionary[word];
           }
            
            else {
                MessageBox.Show(" This word is not founded but you can add it ");
                Form2 f2 = new Form2(0);
                f2.Set(word);
                f2.Show();
            }
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(0);
            f.Show();
        }

        private void displaybutton_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(0);
            f3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            reader.SpeakAsync(search.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reader.SpeakAsync(richTextBox1.Text);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 f4 = new Form4();
            f4.Show();
        }
    }
}
