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
    public partial class frm_masa1 : Form
    {
        public frm_masa1()
        {
            InitializeComponent();
        }

        private void frm_masa1_Load(object sender, EventArgs e)
        {
            cmb_urunler.Items.Add("Makarna");
            cmb_urunler.Items.Add("Pizza");
            cmb_urunler.Items.Add("Hamburger");
            cmb_urunler.Items.Add("Kola");
            cmb_urunler.Items.Add("Gazoz");
            cmb_urunler.Items.Add("Su");
        }

        private void lst_Tablo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            ListViewItem lst = new ListViewItem();
            lst.Text = cmb_urunler.Text;

            if (cmb_urunler.Text == "Makarna")
            {
                lst.SubItems.Add(20.ToString());
            }
            else if (cmb_urunler.Text == "Pizza")
            {
                lst.SubItems.Add(40.ToString());
            }
            else if (cmb_urunler.Text == "Hamburger")
            {
                lst.SubItems.Add(35.ToString());
            }
            else if (cmb_urunler.Text == "Kola")
            {
                lst.SubItems.Add("7");
            }
            else if (cmb_urunler.Text == "Gazoz")
            {
                lst.SubItems.Add("6");
            }
            else if (cmb_urunler.Text == "Su")
            {
                lst.SubItems.Add("3");
            }
            lst_Tablo.Items.Add(lst);

            int toplamFiyat = 0;
            int[] topla = new int[lst_Tablo.Items.Count];
            for (int i = 0; i < lst_Tablo.Items.Count; i++)
            {
                topla[i] = Convert.ToInt32(lst_Tablo.Items[i].SubItems[1].Text);
                toplamFiyat = toplamFiyat + topla[i];
            }
            lbl_toplam.Text = toplamFiyat + " TL";

        }

        public void btn_sil_Click(object sender, EventArgs e)
        {
            //birden fazla seçimlerde fiyat azalmıyor. seçilen ürünlerin fiyatı kadar arttırıyor.

            int fiyatcikar = 0;
            int[] cikar = new int[lst_Tablo.Items.Count];
            foreach  (ListViewItem secilen in lst_Tablo.CheckedItems)
            {
                for (int i = 0; i < lst_Tablo.Items.Count; i++)
                {
                    cikar[i] = Convert.ToInt32(lst_Tablo.Items[i].SubItems[1].Text);
                    fiyatcikar = fiyatcikar - cikar[i];
                    secilen.Remove();
                }
                lbl_toplam.Text =Math.Abs(fiyatcikar).ToString() + " TL";
                //çalışmıyor buna bak.
                Form1 frm = new Form1();
                
                     
                
            }
            if (lst_Tablo.Items.Count == 0)
            {
                lbl_toplam.Text = "0 TL";
            }
            
        }

        private void cmb_urunler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_ode_Click(object sender, EventArgs e)
        {
            int fiyatcikar = 0;
            int[] cikar = new int[lst_Tablo.Items.Count];
            foreach (ListViewItem secilen in lst_Tablo.CheckedItems)
            {
                for (int i = 0; i < lst_Tablo.Items.Count; i++)
                {
                    cikar[i] = Convert.ToInt32(lst_Tablo.Items[i].SubItems[1].Text);
                    fiyatcikar = fiyatcikar - cikar[i];
                    secilen.Remove();
                }
                lbl_toplam.Text = Math.Abs(fiyatcikar).ToString() + " TL";
                //çalışmıyor buna bak.
                Form1 frm = new Form1();
                


            }
            if (lst_Tablo.Items.Count == 0)
            {
                lbl_toplam.Text = "0 TL";
            }
        }
    }
}
