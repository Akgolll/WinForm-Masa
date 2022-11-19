using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasa_isleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            frm_masa1 m1 = new frm_masa1();
            m1.ShowDialog();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Masalar.frm_Masa2 m2 = new Masalar.frm_Masa2();
            m2.ShowDialog();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            Masalar.frm_masa3 m3 = new Masalar.frm_masa3();
            m3.ShowDialog();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            Masalar.frm_Masa4 m4 = new Masalar.frm_Masa4();
            m4.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //çıkan pencere için ayarlamalar.
            string message = "Uygulamayı kapatmak isitiyor mususunuz ?";
            string title = "Çıkış";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            

        }

        private void label2_Click(object sender, EventArgs e)
        {
            // daha sonradan "ödenen hesap" fiyatı burada gözükücek.
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           
        }
    }
}
