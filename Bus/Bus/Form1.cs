using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            koltukdoldur(58, 7);
        }
        void koltukdoldur(int koltuksayisi, int sira)
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 1; i <= koltuksayisi; i++)
            {
               
                Button koltuk = new Button();
                koltuk.ContextMenuStrip = contextMenuStrip1;
                koltuk.MouseDown += Koltuk_MouseDown;
                koltuk.Width = 40;
                koltuk.Height = 40;
                koltuk.Text = i.ToString();
                if (koltuksayisi - 3 == i)
                    koltuk.Margin = new Padding(20, 0, 0, 0);
                else if (koltuksayisi - 1 == i)
                    koltuk.Margin = new Padding(0);
                else if (sira * 4 - 2 == i)
                    koltuk.Margin = new Padding(0, 0, 120, 0);            
                else if (i % 4 == 3 && i < (sira - 1) * 4)
                    koltuk.Margin = new Padding(40, 0, 0, 0);

                else if (i % 4 == 1 && i > (sira) * 4)
                    koltuk.Margin = new Padding(40, 0, 0, 0);
                else
                    koltuk.Margin = new Padding(0);
                flowLayoutPanel1.Controls.Add(koltuk); 
            }
        }
        Button tiklanan;
        private void Koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan = (Button)sender;
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(toolStripComboBox1.SelectedItem.ToString())
            {
               case  "09.00":
                    koltukdoldur(46, 7);
                    break;
                case "10.00":
                    koltukdoldur(42, 6);
                    break;
                case "13.00":
                    koltukdoldur(50, 8);
                    break;
                case "20.00":
                    koltukdoldur(25,3);
                    break;
            }
        }

        private void bayToolStripMenuItem_Click(object sender, EventArgs e)
        {
           kirala(Color.Blue);

        }

        private void  kirala(Color renk)
        {
            kayitformu kayit = new kayitformu();
            DialogResult sonuc = kayit.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                ListViewItem satir = new ListViewItem();
                satir.Text = tiklanan.Text;
                satir.SubItems.Add(kayit.txtname.Text);
                satir.SubItems.Add(kayit.txtsoyad.Text);
                satir.SubItems.Add(kayit.txttelefon.Text);
                listView1.Items.Add(satir);
                tiklanan.BackColor = renk;


            }
        }

        private void bayanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kirala(Color.Pink);
        }
    }
}
