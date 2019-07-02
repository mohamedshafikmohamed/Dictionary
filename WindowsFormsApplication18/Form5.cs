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
using System.Speech;
using System.Speech.Synthesis;
namespace WindowsFormsApplication18
{
    public partial class Form5 : Form
    {
        SpeechSynthesizer reader = new SpeechSynthesizer();
        public int eng_ara_count = 0;
        public int Count = 0;
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        Dictionary<string, string>arabic_dictionary = new Dictionary<string, string>();
        public Form5()
        {
            InitializeComponent();
            if (Count == 0)
            {

              

                    FileStream f = new FileStream("Arabic dictionary.txt", FileMode.Open);
                    StreamReader r = new StreamReader(f);
                    while (r.Peek() != -1)
                    {

                        string s = r.ReadLine();
                        string[] s2 = s.Split(':');
                        s2[0] = s2[0].ToLower();
                        arabic_dictionary[s2[1]] = s2[0];
                        try { dictionary[s2[0]] = s2[1]; }
                        catch { MessageBox.Show(s2[0]); }
                       
                       



                    }
                    
                    r.Close();
                
                Count++;
               
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text.ToLower();

            if (eng_ara_count % 2 == 0)
            {

                if (dictionary.ContainsKey(word))
                {
                    richTextBox1.Text = dictionary[word];
                }

                else
                {
                    MessageBox.Show(" This word is not founded ");
                    Form2 f2 = new Form2(1);
                  

                }
            }
            else
            {
                word = " " + word;

                if (arabic_dictionary.ContainsKey(word))
                {
                    richTextBox1.Text = arabic_dictionary[word];
                }

                else
                {
                    MessageBox.Show(" This word is not founded " );
                    Form2 f2 = new Form2(1);
                   

                }
            }
            
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            if (eng_ara_count % 2 == 0)
            {
                reader.SpeakAsync(textBox1.Text);
            }
            else {
                reader.SpeakAsync(richTextBox1.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(1);
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(1);
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(eng_ara_count%2==0)
            {
                button3.Location = new Point(355, 28);
                label2.Text = "العربية";
                label3.Text = "الانجليزية";
                eng_ara_count++;
            }
            else
            {
                button3.Location = new Point(183, 28);
                button3.Visible = true;
                label3.Text = "العربية";
                label2.Text = "الانجليزية";
                eng_ara_count++;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 f4 = new Form4();
            f4.Show();

        }
    }
}
