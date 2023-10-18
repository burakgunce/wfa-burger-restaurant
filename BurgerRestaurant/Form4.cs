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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            menu.Name = txtMenuName.Text;
            menu.Cost = (int)nudMenuCost.Value;
            Form1.Menuler.Add(menu);

            Helper.ClearBoxes(this.Controls);
        }
    }
}
