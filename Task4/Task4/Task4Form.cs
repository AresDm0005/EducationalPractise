using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Task4
{
    public partial class Task4Form : Form
    {
        public Task4Form()
        {
            InitializeComponent();
        }

        private double Equation(double x)
        {
            return x * x * x - 0.2 * x * x - 0.2 * x - 1.2;
        }

        private double Solve(double eps)
        {
            double left = 1, right = 1.5;

            while (right - left > eps)
            {
                double mid = left + (right - left) / 2.0;
                if (Equation(right) * Equation(mid) <= 0) left = mid;
                else right = mid;
            }

            return left;
        }

        private bool CheckInput(out string error)
        {
            error = "";
            double eps = -1;
            bool ok = double.TryParse(epsBox.Text, out eps);

            error = "Значение ε введено некорректно";
            return (ok && eps != 0);
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            string error;
            if (!CheckInput(out error))
            {
                MessageBox.Show(error, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double eps = double.Parse(epsBox.Text);
            resBox.Text = Solve(eps).ToString();
        }

        private void epsBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[,\d]") && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
