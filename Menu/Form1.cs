using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edward_Lie_A3
{
    public partial class Form1 : Form
    {
        const decimal TAX = 0.10m;
        decimal[] elements = new decimal[4] { 0, 0, 0, 0 };
        decimal subTotal()
        {
            return elements.Sum();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        elements[0] = 1.95m;
                        break;
                    }
                case 1:
                    {
                        elements[0] = 1.50m;
                        break;
                    }
                case 2:
                    {
                        elements[0] = 1.25m;
                        break;
                    }
                case 3:
                    {
                        elements[0] = 2.95m;
                        break;
                    }
                case 4:
                    {
                        elements[0] = 0m;
                        break;
                    }
            }
            CalculateBill();
        }
        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    {
                        elements[1] = 5.95m;
                        break;
                    }
                case 1:
                    {
                        elements[1] = 8.95m;
                        break;
                    }
                case 2:
                    {
                        elements[1] = 6.95m;
                        break;
                    }
                case 3:
                    {
                        elements[1] = 9.95m;
                        break;
                    }
                case 4:
                    {
                        elements[1] = 11.95m;
                        break;
                    }
                case 5:
                    {
                        elements[1] = 0m;
                        break;
                    }
            }
            CalculateBill();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    {
                        elements[2] = 16.95m;
                        break;
                    }
                case 1:
                    {
                        elements[2] = 12.95m;
                        break;
                    }
                case 2:
                    {
                        elements[2] = 19.95m;
                        break;
                    }
                case 3:
                    {
                        elements[2] = 20.95m;
                        break;
                    }
                case 4:
                    {
                        elements[2] = 17.95m;
                        break;
                    }
                case 5:
                    {
                        elements[2] = 18.95m;
                        break;
                    }
                case 6:
                    {
                        elements[2] = 0m;
                        break;
                    }
            }
            CalculateBill();
        }

        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (comboBox4.SelectedIndex)
            {
                case 0:
                    {
                        elements[3] = 4.95m;
                        break;
                    }
                case 1:
                    {
                        elements[3] = 3.95m;
                        break;
                    }
                case 2:
                    {
                        elements[3] = 5.95m;
                        break;
                    }
                case 3:
                    {
                        elements[3] = 5.95m;
                        break;
                    }
                case 4:
                    {
                        elements[3] = 0m;
                        break;
                    }
            }
            CalculateBill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            elements = new decimal[4] { 0, 0, 0, 0 };
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "$0.00";
            textBox4.Text = "$0.00";
            textBox5.Text = "$0.00";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
        }

        private void CalculateBill()
        {
            var sub = subTotal();
            textBox3.Text = sub.ToString("c");
            textBox4.Text = (sub * TAX).ToString("c");
            textBox5.Text = (sub + sub * TAX).ToString("c");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a number only!");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please only enter alphabetic characters!");
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
