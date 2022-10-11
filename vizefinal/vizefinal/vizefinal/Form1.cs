using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vizefinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
            label8.Text = "";
            label9.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            try
            {
                double num1, num2;
                num1 = Convert.ToDouble(numvize.Value);
                num2 = Convert.ToDouble(numfinal.Value);
                double numort = num1 * 0.4 + num2 * 0.6;
                label4.Text = numort.ToString();
                label8.Text = numort.ToString();
                label9.Text = numort.ToString();

                if (numort <= 100 && numort >= 92)
                {
                    label8.Text = "AA";
                    label9.Text = "GEÇTİ";
                    label9.ForeColor = Color.Green;
                }
                else if (numort <= 91 && numort >= 85)
                {
                    label8.Text = "BA";
                    label9.Text = "GEÇTİ";
                    label9.ForeColor = Color.Green;
                }
                else if (numort <= 84 && numort >= 78)
                {
                    label8.Text = "BB";
                    label9.Text = "GEÇTİ";
                    label9.ForeColor = Color.Green;
                }
                else if (numort <= 77 && numort >= 71)
                {
                    label8.Text = "CB";
                    label9.Text = "GEÇTİ";
                    label9.ForeColor = Color.Green;
                }
                else if (numort <= 70 && numort >= 64)
                {
                    label8.Text = "CC";
                    label9.Text = "GEÇTİ";
                    label9.ForeColor = Color.Green;
                }
                else if (numort <= 63 && numort >= 57)
                {
                    label8.Text = "DC";
                    label9.Text = "GEÇTİ";
                    label9.ForeColor = Color.Green;
                }
                else if (numort <= 56 && numort >= 50)
                {
                    label8.Text = "DD";
                    label9.Text = "GEÇTİ";
                    label9.ForeColor = Color.Green;
                }
                else if (numort <= 49 && numort >= 40)
                {
                    label8.Text = "FD";
                    label9.Text = "KALDI";
                    label9.ForeColor = Color.Red;
                }
                else if (numort <= 39 && numort >= 1)
                {
                    label8.Text = "FF";
                    label9.Text = "KALDI";
                    label9.ForeColor = Color.Red;
                }
                else if (numort == 0)
                {
                    label8.Text = "FF";
                    label9.Text = "KALDI";
                    label9.ForeColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Değerleri kontrol ediniz!!");
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message); 
            }



        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Bu uygulama üniversitelerin genel vize-final oranları (%40-%60) baz alınarak yapılmıştır.", "Yardım");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
