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

        private bool CheckInputs(out string error)
        {
            error = "";
            if (xBox.Text == "" || yBox.Text == "")
            {
                error = "Одно из значений координат не было введено!";
                return false;
            }

            double tmp;
            if (!double.TryParse(xBox.Text, out tmp))
                error += "Значение координаты X было введено некорректно\n";
            if (!double.TryParse(yBox.Text, out tmp))
                error += "Значение координаты Y было введено некорректно\n";

            return error == "";
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            string error;
            if(!CheckInputs(out error))
            {
                MessageBox.Show(error, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
