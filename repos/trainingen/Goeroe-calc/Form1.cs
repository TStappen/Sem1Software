using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPresentatie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddClick(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);

           labelOutput(num1 + num2);
        }

        private void buttonMultClick(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);

            labelOutput(num1 * num2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonWortel_click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);

            labelOutput(Math.Sqrt(num1));
        }

        private void labelOutput(double v)
        {
            if (v < 0)
            {
                labelAntwood.ForeColor = Color.Red;
            } else
            {
                labelAntwood.ForeColor = Color.Black;
            }

            labelAntwood.Text = "Uitkomst: " + Convert.ToString(v);
        }

        private void buttonDivisionClick(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);

            if (num1 == 0 || num2 == 0)
            {
                labelAntwood.Text = "Niet door 0 delen";
            }
            else
            {
                labelOutput(num1 / num2);
            }
        }
    }
}
