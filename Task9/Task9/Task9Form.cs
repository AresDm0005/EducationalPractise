using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Task9
{
    public partial class Task9Form : Form
    {
        private Random rand = new Random();

        public Task9Form()
        {
            InitializeComponent();
        }

        private void arrayBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d\s\b\-]"))
                e.Handled = true;
        }

        private void rndButton_Click(object sender, EventArgs e)
        {
            int len = rand.Next(5, 11);
            string txt = "";
            for (int i = 0; i < len; i++)
                txt += rand.Next(-50, 50).ToString() + " ";

            arrayBox.Text = txt;
        }

        private bool CheckInput(ref int[] arr, out string error)
        {
            error = string.Empty;

            string[] str = arrayBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            arr = new int[str.Length];
            for(int i = 0; i < str.Length; i++)
            {
                if (!int.TryParse(str[i], out arr[i]))
                    error += $"Элемент на позиции {i + 1} введен некорректно\n";
            }

            return error == string.Empty;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            int[] arr = null;
            string error;
            
            if(!CheckInput(ref arr, out error))
            {
                MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List list = new List(arr);

            recResLabel.Text = list.SumRecursive().ToString();
            iterResLabel.Text = list.SumIterative().ToString();
        }
    }
}
