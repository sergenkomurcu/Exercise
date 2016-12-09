using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace margindeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sira = 7;
            for (int i = 1; i <= 60; i++)
            {
                Button but = new Button();
                but.Width = 40;
                but.Height = 40;
                but.Margin = new Padding(0);
                but.Text = i.ToString();
               if(i%4==3)
                {
                    but.Margin = new Padding(40, 0, 0, 0);


                }
               


                flowLayoutPanel1.Controls.Add(but);
                
            }
        }
    }
}
