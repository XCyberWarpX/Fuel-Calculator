using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Fuel_calculator
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            decimal kmTravNumber, litUsedNumber;

            kmTravNumber = Decimal.Parse(kmTrav.Text);
            litUsedNumber = Decimal.Parse(litUsed.Text);

            decimal result = (litUsedNumber / kmTravNumber) * 100;
            this.litPer100km.Text = Math.Round(result, 2).ToString();
        }

        private void kmTrav_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void litUsed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

    }
}
