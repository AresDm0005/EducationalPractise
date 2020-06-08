using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Task10
{
    public partial class Task10Form : Form
    {
        public Task10Form()
        {
            InitializeComponent();
        }

        private void nBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d]") && e.KeyChar != 8)
                e.Handled = true;
        }

        private void arrayBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d\s\-]") && e.KeyChar != 8)
                e.Handled = true;
        }

        private bool HandleInputs(ref int[] arr, out string error)
        {
            error = string.Empty;
            if (arrayBox.Text == "")
            {
                error = "Не введены значения x\n";
                return false;
            }

            string[] str = arrayBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            arr = new int[str.Length];

            for (int i = 0; i < str.Length; i++)
                if (!int.TryParse(str[i], out arr[i]))
                    error += $"Некорректно введено значение: {str[i]} на позиции {i + 1} \n";

            int N;
            if (int.TryParse(nBox.Text, out N))
            {
                if (N != arr.Length)
                    error += "Количество элементов Xi не соответствует введенному N";
            }
            else
            {
                if(nBox.Text.Length != 0)
                    error += "Число N не введено или введено некорректно";
            }

            return error == string.Empty;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            int[] arr = null; 
            string error = "";
            if(!HandleInputs(ref arr, out error))
            {
                MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK);
                return;
            }

            TwoWayList list = new TwoWayList(arr);

            resLabel.Text = list.Solve().ToString();
        }
    }
}
