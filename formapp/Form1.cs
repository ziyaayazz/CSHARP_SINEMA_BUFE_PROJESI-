using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            label7.Text = "Boş koltuk sayısı : "+salon.BosKoltukOgren();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            salon.BiletIptal(checkBox1.Checked);
            label7.Text = "Bilet iptal edildi . Kalan koltuk Sayısı : " + salon.BosKoltukOgren();

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = "Şu anki bakiye : " + salon.BakıyeOgren();
        }
        Sinema salon;

        private void button1_Click(object sender, EventArgs e)
        {
            salon = new Sinema(textBox1.Text, Convert.ToInt32(textBox2.Text));
            label7.Text = "Salon oluşturuldu . Koltuk Sayısı : " + salon.BosKoltukOgren();
        }

        private void label3_Click(object sender, EventArgs e)
        {
             
        }

        private void label6_Click(object sender, EventArgs e)
        {
 
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            salon.BiletSat(checkBox1.Checked);
            label7.Text = "Bilet satıldı . Kalan koltuk Sayısı : " + salon.BosKoltukOgren();
        }

        private void BÜFE_Click(object sender, EventArgs e)
        {
            Form2 büfe = new Form2(salon.BakıyeOgren());
            büfe.Show();

        }
    }
}
