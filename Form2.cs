using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _123
{
    public partial class Form2 : Form
    {
        public string directory;
        public string name;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            directory = "";
            label2.Text = "";
            string name1="*.";
            name1 += textBox1.Text;
            name1 += "*";
            //name = textBox1.Text;

            directory = textBox2.Text;
            
            //string directory = @"D:\";
            try
            {MessageBox.Show(directory);
                foreach (var fi in new DirectoryInfo(directory).EnumerateFiles(name1, SearchOption.AllDirectories))
                {
                    //MessageBox.Show(fi.FullName);
                    label2.Text += fi.FullName+"\n";

                }
            }
            catch (Exception) { }
            
        }
    }
}
