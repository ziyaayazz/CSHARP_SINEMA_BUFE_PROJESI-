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
    public partial class Form2 : Form
    {
        public Form2(double BakiyeOgren())
            
        {
            InitializeComponent();
            kasa = BakiyeOgren;

        }
            double kasa;
        
        private void button1_Click(object sender, EventArgs e)
        {
            int mısır, su, cay,toplam;
            cay = Convert.ToInt32(textBox1.Text);
            mısır=Convert.ToInt32(textBox2.Text);
            su= Convert.ToInt32(textBox3.Text);

            toplam = cay * 2 + su * 1 + mısır * 4;
            label6.Text = toplam.ToString();

            kasa = kasa + toplam;
            label10.Text = kasa.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label6.Text = "";
        }

    }
}
