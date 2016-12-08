using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minedeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mineolusturma(5, 10);
           
        }

        void mineolusturma(int mayin, int b)
        {
            flowLayoutPanel1.Width = 30 * b;
            flowLayoutPanel1.Height = 30 * b;
            int[] mayinhafizasi = new int[mayin];
            Random rnd = new Random();
            for (int j = 0; j < mayin; j++)

            {
                int secilen = rnd.Next(0, b * b);
                if(mayinhafizasi.Contains(secilen))
                {
                    j--;
                    continue;

                }
                mayinhafizasi[j] = secilen;
            }



            for (int i = 0; i < b * b; i++)
            {
                Button minebutton = new Button();
                minebutton.Width = 30;
                minebutton.Height = 30; 
                minebutton.Margin = new Padding(0);
                minebutton.Tag = mayinhafizasi.Contains(i);
                minebutton.Click += Minebutton_Click;
                flowLayoutPanel1.Controls.Add(minebutton);
           
            }
            

         



        }

        private void Minebutton_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button) sender;
            bool kare = (bool)tiklanan.Tag;
            if(kare==true)
            {

                tiklanan.BackColor = Color.Red;

            }
            else
            {
                tiklanan.BackColor = Color.Azure; 


            }


        }
    }
}
