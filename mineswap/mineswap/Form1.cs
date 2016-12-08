using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mineswap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            mayindoldur(10, 10);

        }

        void mayindoldur(int mayin, int boyut)
        {

            flowLayoutPanel1.Width = boyut * 30;
            flowLayoutPanel1.Height = boyut * 30;
            int[] mayinlar = new int[mayin];
            Random rnd = new Random();
            for(int i=0;i<mayin;i++)
            {
                    
               int secilen = rnd.Next(0, boyut * boyut);
                //contains= iceriyor mu komutu//
               if(mayinlar.Contains(secilen))
                {
                    i--;
                    continue;
                }
                mayinlar[i] = secilen;
            }





            for (int i = 0; i < boyut*boyut; i++)
            {
                Button btn = new Button();
                btn.Width = 30;
                btn.Height = 30;
                btn.Margin = new Padding(0);
                btn.Tag = mayinlar.Contains(i);
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);


            }


        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            bool durum = (bool)tiklanan.Tag;
            if (durum == true)
            {
                tiklanan.BackColor = Color.Red;
                MessageBox.Show("oyun bitti");
            }
            else
            {

                tiklanan.BackColor = Color.Green;
            }
           
        }
    }
}
