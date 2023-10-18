using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace BurgerRestaurant.Concrete
{
    public class Order
    {
        public Order()
        {
            Malzemeler = new List<Material>();
        }

        public Menu Menu { get; set; }

        public List<Material> Malzemeler { get; set; }
        public Boy Boy { get; set; }
        public int Adet { get; set; }

        private double toplamFiyat;
        public double ToplamFiyat
        {
            get
            {
                toplamFiyat = (double)Menu.Cost;
                if (this.Boy == Boy.orta)
                {
                    toplamFiyat *= 1.2;
                }
                else if (this.Boy == Boy.büyük)
                {
                    toplamFiyat *= 1.4;
                }

                foreach (Material Material in this.Malzemeler)
                {
                    toplamFiyat += (double)Material.Cost;
                }

                toplamFiyat *= this.Adet;
                return toplamFiyat;
            }
        }

        public double EkstraMaterialFiyatlari()
        {
            double toplam = 0;
            foreach (Material material in this.Malzemeler)
            {
                toplamFiyat += (double)material.Cost;

            }

            return toplam;
        }


        public override string ToString()
        {
            string ekstraMalzemelerIsimleri = string.Empty;
            foreach (Material Material in this.Malzemeler)
            {
                ekstraMalzemelerIsimleri += Material.Name + " ";
            }

            string bilgi = $"{this.Adet} {this.Menu.Name} , {ekstraMalzemelerIsimleri} , {this.Boy} || Toplam : {this.ToplamFiyat} ";

            return bilgi;
        }
    }
}
