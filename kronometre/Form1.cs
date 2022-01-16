using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     

        private void button1_Click(object sender, EventArgs e)
        {

            baslat();
           

        }
        int salise=0,saniye=0,dakika=0;

        private void button4_Click(object sender, EventArgs e)
        {
            turKaydet();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            sifirla();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            durdur();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
            salise++;
                if (salise == 100) {
                salise = 0;
                saniye++;
            }
            if (saniye==60)
            {
                saniye = 0;
                dakika++;
                    
            }
            lbl_salise.Text = salise.ToString();
            lbl_saniye.Text = saniye.ToString();
            lbl_dakika.Text = dakika.ToString();

        }
       public void sifirla()
        {
            timer1.Stop();
            salise = 0;
            saniye = 0;
            dakika = 0;
            lbl_salise.Text = salise.ToString();
            lbl_saniye.Text = saniye.ToString();
            lbl_dakika.Text = dakika.ToString();
            listBox1.Items.Clear();
        }
        public void turKaydet()
        {
            timer1.Stop();
            listBox1.Items.Add(dakika + ":" + saniye + ":" + salise);
        }
        public void baslat()
        {
            timer1.Start();
        }
        public void durdur()
        {
            timer1.Stop();
        }
    }

}


