using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming2
{
    public partial class IceCreamOrderForm : Form
    {
        public IceCreamOrderForm()
        {
            InitializeComponent();
        }

        private void vanillaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            flavorLabel.Text = "Vanilla with";
        }

        private void chocolateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            flavorLabel.Text = "Chocolate with";
        }

        private void strawberryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            flavorLabel.Text = "Strawberry with";
        }

        private void iceCreamSelectButton_Click(object sender, EventArgs e)
        {
            toppingsLabel.Text = "";

            if(whipCreamCheckBox.Checked)
            {
                toppingsLabel.Text += "Whip Cream \n";
            }

            if(brownieCheckBox.Checked)
            {
                toppingsLabel.Text += "Brownies \n";
            }

            if(cherriesCheckBox.Checked)
            {
                toppingsLabel.Text += "Cherries \n";
            }

            if(bananaCheckBox.Checked)
            {
                toppingsLabel.Text += "Bananas \n";
            }

            if(oreosCheckBox.Checked)
            {
                toppingsLabel.Text += "Oreos \n";
            }

            if(sprinklesCheckBox.Checked)
            {
                toppingsLabel.Text += "Sprinkles \n";
            }

            if(nutsCheckBox.Checked)
            {
                toppingsLabel.Text += "Nuts \n";
            }
        }

        private void IceCreamOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void applySyrupButton_Click(object sender, EventArgs e)
        {
            syrupLabel.Text = "";

            string syrup;

            if (syrupListBox.SelectedIndex != -1)
            {
                syrup = syrupListBox.SelectedItems.ToString();

                switch (syrup)
                {
                    case "Caramel":
                        syrupLabel.Text = "Caramel";
                        break;
                    case "Chocolate":
                        syrupLabel.Text = "Chocolate";
                        break;
                    case "Fudge":
                        syrupLabel.Text = "Fudge";
                        break;
                    case "Strawberry":
                        syrupLabel.Text = "Strawberry";
                        break;
                }
            }
        }
    }
}
