using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Task6
{
    public partial class Task6Form : Form
    {
        private int N, M, tmp;
        private int[] arr;     

        public Task6Form()
        {
            InitializeComponent();
        }

        private void Seq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d\-]") && e.KeyChar != 8)
                e.Handled = true;
        }

        private void Params_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d]") && e.KeyChar != 8)
                e.Handled = true;
        }

        private bool HandleConst()
        {
            bool ok = false;
            string error = "";

            ok = int.TryParse(nBox.Text, out N);
            if (!ok)
                error += "Значение N введено некорректно или не введено совсем\n";

            if (ok && N < 3)
                error += "Значение N должно быть больше или равно 3";
                

            ok = int.TryParse(mBox.Text, out M);
            if (!ok)
                error += "Значение M введено некорректно или не введено совсем\n";

            if (error != "")
                MessageBox.Show(error);

            return error == "";
        }

        private bool HandleInputs(out int fl)
        {
            fl = -1;
            bool ok = HandleConst();            
            if (!ok) return ok;
            string error = "";

            arr = new int[N];
            tmp = M;

            
            for(int i = 0; i < 3; i++)
            {
                ok = int.TryParse(((TextBox)Controls.Find($"a{i + 1}Box", true)[0]).Text, out arr[i]);
                N--;

                if (arr[i] % 3 == 0)
                    M--;

                if (M <= 0 && N <= 0 && fl != 1)
                    fl = 2;
                else if (M <= 0)
                    fl = 1;


                if (!ok)
                    error += $"Значение a{i + 1} введено некорректно или не введено совсем\n";
            }

            if (error != "")
                MessageBox.Show(error, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return error == "";
        }

        private int Recursion(int index)
        {
            if (N <= 0 && M <= 0) return 3;
            else if (N <= 0) return 1;
            else if (M <= 0) return 2;

            arr[index] = 2 * Math.Abs(arr[index - 1] - arr[index - 2]) + arr[index - 3];
            N--;
            if (arr[index] % 3 == 0) M--;
            return Recursion(index+1);            
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            int fl;
            if (!HandleInputs(out fl))
                return;

            // 1 - по N, 2 - по M, 3 - и по N, и по M

            int result = -1;
            if (fl == -1)
                result = Recursion(3);            
            string txt = "";

            if (result == 1)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                    txt += $"{arr[i]}, ";

                txt += arr[arr.Length - 1].ToString();

                resultLabel.Text = "построено N элементов последовательности";
                resultBox.Text = txt;                
            } 
            else if (result == 2 || fl == 1)
            {

                foreach (int it in arr)
                    if (it % 3 == 0 && tmp-- > 0)
                        if (tmp != 0)
                            txt += $"{it}, ";
                        else 
                            txt += $"{it}";                    

                resultLabel.Text = "найдено M элементов последовательности кратных 3";
                resultBox.Text = txt;
            }
            else
            {
                foreach (int it in arr)
                    txt += $"{it}, ";

                resultLabel.Text = "одновременно было построено N элементов и найдено M кратных 3";
                resultBox.Text = txt;
            }
        }
    }
}
