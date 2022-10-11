using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroDollarConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nmrUpDownRate.Maximum = decimal.MaxValue;
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            tbEuroAmount.Text = Convert.ToString((double)Convert.ToDecimal(tbDollarAmount.Text) / (double)nmrUpDownRate.Value);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            tbDollarAmount.Text = Convert.ToString((double)Convert.ToDecimal(tbEuroAmount.Text) * (double)nmrUpDownRate.Value);
        }

        private void tbDollarAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) ||
               ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)))
            {
                foutmelding();
                e.Handled = true;
            }
        }

        private void tbEuroAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) ||
               ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)))
            {
                foutmelding();
                e.Handled = true;
            }
        }



        private void foutmelding()
        {
            System.Windows.Forms.MessageBox.Show("Er wordt niets berekend!");
        }

        private void buttonDollar_Click(object sender, EventArgs e)
        {
            labelDollar.Text = "$";
            labelRate.Text = "Koers: 1 euro = $";
        }

        private void buttonYen_Click(object sender, EventArgs e)
        {
            labelDollar.Text = "¥";
            labelRate.Text = "Koers: 1 euro = ¥";
        }
    }
}


