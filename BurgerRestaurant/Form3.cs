using BurgerRestaurant.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerRestaurant
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            double ciro = 0;
            int toplamSiparis = 0;
            double ekstraMalzemeGeliri = 0;
            int satilanUrunAdedi = 0;
            foreach (Order siparis in Form1.Siparisler)
            {
                lstOrders.Items.Add(siparis);
                ciro += siparis.ToplamFiyat;

                ekstraMalzemeGeliri += siparis.EkstraMaterialFiyatlari();

                satilanUrunAdedi += siparis.Malzemeler.Count * siparis.Adet;

                satilanUrunAdedi += siparis.Adet;
            }

            toplamSiparis = Form1.Siparisler.Count;

            lblGiro.Text = ciro.ToString("C2");
            lblTotalOrders.Text = toplamSiparis.ToString();
            lblExtraMaterial.Text = ekstraMalzemeGeliri.ToString("C2");
            lblTotalProduct.Text = satilanUrunAdedi.ToString();
        }
    }
}
