using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Task3
{
    public partial class Task3Form : Form
    {
        public Task3Form()
        {
            InitializeComponent();
        }

        private void XY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\-,\d]") && e.KeyChar != 8)
                e.Handled = true;
        }

        private void XY_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            double tmp;
            bool ok = double.TryParse(textBox.Text, out tmp);

            if (!ok)
            {
                MessageBox.Show($"Значение координаты {textBox.Name[0].ToString().ToUpper()} было введено некорректно", 
                    "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.SelectAll();
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (xBox.Text == "" || yBox.Text == "")
            {
                MessageBox.Show("Одно из значений координат не было введено!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double X = Convert.ToDouble(xBox.Text),
                Y = Convert.ToDouble(yBox.Text);

            pointLabel.Text = string.Format("A ({0:f3}; {1:f3})", X, Y);

            if (Math.Abs(X) <= 1 && Math.Abs(Y) <= 1)
            {
                resultLabel.Text = "ПРИНАДЛЕЖИТ";
                resultLabel.ForeColor = Color.DarkGreen;
            }
            else
            {
                resultLabel.Text = "НЕ ПРИНАДЛЕЖИТ";
                resultLabel.ForeColor = Color.DarkRed;
            }
        }
    }
}
