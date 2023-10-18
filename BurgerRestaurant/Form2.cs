using BurgerRestaurant.Concrete;
using BurgerRestaurant.Utilities;
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
    public partial class Form2 : Form
    {
        Helper helper = new Helper();
        public Form2()
        {
            InitializeComponent();
            YeniSiparisler = new List<Order>();
        }

        List<Order> YeniSiparisler;
        double toplam = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Menu menu in Form1.Menuler)
            {
                cboxMenu.Items.Add(menu);
            }

            foreach (Material melzeme in Form1.Malzemeler)
            {
                flowLayoutPanel1.Controls.Add(new CheckBox() { Text = melzeme.Name, Tag = melzeme });
            }

            cboxMenu.SelectedItem = 0;
            rbtnSmall.Checked = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        }


        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            Order siparis = new Order();

            siparis.Menu = (Menu)cboxMenu.SelectedItem;

            foreach (CheckBox cbox in flowLayoutPanel1.Controls)
            {
                if (cbox.Checked)
                {
                    siparis.Malzemeler.Add((Material)cbox.Tag);

                }
            }

            if (rbtnMiddle.Checked)
            {
                siparis.Boy = Boy.orta;
            }
            else if (rbtnBig.Checked)
            {
                siparis.Boy = Boy.büyük;
            }
            else
            {
                siparis.Boy = Boy.kucuk;
            }

            siparis.Adet = (int)nudPiece.Value;

            toplam += siparis.ToplamFiyat;
            lblTotalCost.Text = toplam.ToString("C2");

            YeniSiparisler.Add(siparis);
            listBox1.Items.Add(siparis);

            Helper.ClearBoxes(this.Controls);

        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Siparişi onaylıyor musunuz ?", "Onay", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                Form1.Siparisler.AddRange(YeniSiparisler);
                listBox1.Items.Clear();
                YeniSiparisler.Clear();
                lblTotalCost.Text = "0.00";
            }

            Helper.ClearBoxes(this.Controls);
        }

        //private void BringMenus()
        //{
        //    foreach (Menu menu in Form4.menus)
        //    {
        //        ComboBox comboBox = new ComboBox
        //        {
        //            Tag = menu
        //        };
        //        cboxMenu.Items.Add(menu.Name);
        //    }


        //}

        //private void BringMaterials()
        //{
        //    flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;

        //    foreach (Material material in Form5.materials)
        //    {
        //        CheckBox checkBox = new CheckBox
        //        {
        //            Text = material.Name,
        //            Tag = material
        //        };
        //        flowLayoutPanel1.Controls.Add(checkBox);
        //    }

        //}

        //private decimal DefineCoefficentAccordingToSize(decimal cost)
        //{
        //    if (rbtnSmall.Checked)
        //    {
        //        return cost * 1;
        //    }
        //    else if (rbtnMiddle.Checked)
        //    {
        //        return cost * 1.2m;
        //    }
        //    else
        //    {
        //        return cost * 1.4m;
        //    }

        //}


        //private decimal DefineCostAccordingToMaterials(List<CheckBox> checkboxes)
        //{
        //    decimal totalCostOfMaterials = 0;

        //    foreach (CheckBox checkbox in checkboxes)
        //    {
        //        if (checkbox.Checked)
        //        {
        //            Material material = (Material)checkbox.Tag;
        //            totalCostOfMaterials += material.Cost;
        //        }
        //    }

        //    return totalCostOfMaterials;
        //}

        //decimal totalCost = 0;
        //List<Order> orders = new List<Order>();



        //decimal menuCost = BringMenuCost();
        //decimal newMenuCost = DefineCoefficentAccordingToSize(menuCost);
        //decimal totalCostOfMaterials = (int)nudPiece.Value * DefineCostAccordingToMaterials(GetSelectedMaterialCheckboxes());

        //// Yeni siparişi oluştur
        //Order newOrder = new Order
        //{
        //    MenuCost = newMenuCost,
        //    MaterialCost = totalCostOfMaterials,
        //    Quantity = (int)nudPiece.Value
        //};

        //orders.Add(newOrder); // Siparişi listeye ekle

        //// Toplam fiyatı hesapla
        //totalCost = orders.Sum(order => (order.MenuCost + order.MaterialCost) * order.Quantity);

        //lblTotalCost.Text = totalCost.ToString();

        //decimal menuCost = BringMenuCost();
        //decimal newMenuCost = DefineCoefficentAccordingToSize(menuCost);
        //decimal totalCostOfMaterials = (int)nudPiece.Value * DefineCostAccordingToMaterials(GetSelectedMaterialCheckboxes());
        //totalCost = newMenuCost * (int)nudPiece.Value;
        //totalCost += totalCostOfMaterials;
        //lblTotalCost.Text = totalCost.ToString();



        //private decimal BringMenuCost()
        //{
        //    string menu = cboxMenu.Text;
        //    decimal cost;
        //    foreach (var item in Form4.menus)
        //    {
        //        if (menu == item.Name)
        //        {
        //            cost = item.Cost;
        //            return cost;
        //        }
        //        return 0;
        //    }
        //    return 0;
        //}

        //private List<CheckBox> GetSelectedMaterialCheckboxes()
        //{
        //    List<CheckBox> selectedCheckboxes = new List<CheckBox>();

        //    foreach (Control control in flowLayoutPanel1.Controls)
        //    {
        //        if (control is CheckBox checkbox && checkbox.Checked)
        //        {
        //            selectedCheckboxes.Add(checkbox);
        //        }
        //    }

        //    return selectedCheckboxes;
        //}
    }
}
