using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2();

            F.Show();
            //System.Drawing.Drawing2D.GraphicsPath Form_Path = new System.Drawing.Drawing2D.GraphicsPath();
            //GraphicsPath myPath = new GraphicsPath();
            //Form_Path.AddPie(0, 0, 250, 300, -45, 90);
            //Pen myPen = new Pen(Color.Black, 2);
            //Graphics.DrawPath(myPen, Form_Path);


            //Region Form_Region = new Region(Form_Path);
            //F.Region = Form_Region;

        }
    }
}
