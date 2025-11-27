using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgt_gorsel27Kas3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                button1.Text = "Sistemi Başlat";
                button1.BackColor = Color.LightGreen;
            }
            else
            {
                timer1.Start();
                button1.Text = "Sistemi Durdur";
                button1.BackColor = Color.Salmon;
            }
        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            // sayac her saniye 1 artacak
            sayac++;
            // sayac'ı switch case ile kontrol et
            // 1. saniyede kırmızı
                
            // 5. saniyede sarı
            // 7. saniyede yeşil
            // 15. saniyede tekrar başa dönsün
        }
    }
}
