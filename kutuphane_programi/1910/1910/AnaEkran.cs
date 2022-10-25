using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1910
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
            
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEklemeEkrani kitapEklemeEkrani = new KitapEklemeEkrani(this);
            kitapEklemeEkrani.Show();
            this.Hide();
        }
        public void itemekle(String item)
        {
            listBox1.Items.Add(item);
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                button1.Enabled=true;
                button2.Enabled=true;
            }
            else if(listBox1.SelectedIndex == -1)
            {
                button1.Enabled=false;
                button2.Enabled=false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            KitapGuncelle kitGun = new KitapGuncelle(this);
            kitGun.Show();
            this.Hide();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            int secim = listBox1.SelectedIndex;
            DialogResult sil;
            sil = MessageBox.Show("Silmek İstediğinize Emin Misiniz","UYARI!!!",MessageBoxButtons.YesNo);
            if(sil == DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(secim);
            }
            
           

        }
    }
}
