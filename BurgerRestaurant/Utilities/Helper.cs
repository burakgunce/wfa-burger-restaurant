using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurant.Utilities
{
    public class Helper
    {
        public static void ClearBoxes(Control.ControlCollection controlCollection)
        {
            foreach (Control control in controlCollection)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = 0;
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                else if (control is RadioButton)
                {
                    RadioButton rb = (RadioButton)control;
                    if (rb.Name == "rbtnSmall")
                    {
                        rb.Checked = true;
                    }
                    else { rb.Checked = false; }
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;

                }
                else if (control is FlowLayoutPanel)
                {
                    FlowLayoutPanel flowLayoutPanel = (FlowLayoutPanel)control;
                    ClearBoxes(flowLayoutPanel.Controls);
                }
                else if (control is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)control;
                    ClearBoxes(groupBox.Controls);
                }
            }
        }
    }
}
