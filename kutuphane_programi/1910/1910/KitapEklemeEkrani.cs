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
    public partial class KitapEklemeEkrani : Form
    {
        AnaEkran anaEkran;
        public KitapEklemeEkrani(AnaEkran parametredenGelenAnaEkran)
        {
            InitializeComponent();
            anaEkran = parametredenGelenAnaEkran;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string yazarVeKitap = $"Yazar: {textBox1.Text} - Kitap adı: {textBox2.Text}";
            anaEkran.itemekle(yazarVeKitap);
            anaEkran.Show();
            this.Close();
        }
        public void txtekle(string txtEkle)
        {
            string txt1, txt2;
            txt1 = textBox1.Text;
            txt2 = textBox2.Text;
        }

        private void KitapEklemeEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            anaEkran.Show();
        }
    }
}
