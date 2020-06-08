using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Task7
{
    public partial class Task7Form : Form
    {
        public Task7Form()
        {
            InitializeComponent();
        }

        private void vecBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[01*]") && e.KeyChar != 8)
                e.Handled = true;
        }

        private bool HandleInput()
        {
            if (vecBox.Text == "")
            {
                MessageBox.Show("Не был введен вектор", "Ошибка!", MessageBoxButtons.OK);
                return false;
            }

            string txt = vecBox.Text;
            int pow = 1;

            bool ok = false;
            while (!ok && pow <= txt.Length)
            {
                if (pow == txt.Length)
                    ok = true;
                
                pow *= 2;
            }

            if(!ok)
            {
                MessageBox.Show("Введен вектор некорректной длины.\rДлина вектора должна быть равна степени 2");
                return false;
            }

            return true;
        }

        private void AddOne(ref int[] arr)
        {
            bool next = true;
            for(int i = arr.Length - 1; i >= 0 && next; i--)
            {
                if (arr[i] == 0)
                    next = false;

                arr[i] = (arr[i] + 1) % 2;
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (!HandleInput())
                return;

            string txt = vecBox.Text;
            int N = txt.Length;
            int[] vector = new int[N];
            int blanks = 0;
            int[] pos = new int[N];
            int[] bl;

            for(int i = 0; i < N; i++)
            {
                if (txt[i] == '*')
                {
                    vector[i] = -1;
                    pos[blanks] = i;
                    blanks++;
                }
                else
                {
                    vector[i] = int.Parse(txt[i].ToString());
                }
            }

            Solver solver;
            if (blanks == 0)
            {
                solver = new Solver(vector);
                resBox.Text = (solver.IsLinear() ? "Данная функция линейна" : "Данная функция не линейна");
                return;
            }

            bl = new int[blanks];

            int pow = 1;
            for(int i = 0; i < blanks; i++)
            {
                bl[i] = 0;
                pow *= 2;
            }

            string res = "";
            for(int i = 0; i < pow; i++)
            {
                for (int j = 0; j < blanks; j++)
                    vector[pos[j]] = bl[j];

                solver = new Solver(vector);
                bool ok = solver.IsLinear();

                if (ok) {
                    for (int j = 0; j < N; j++)
                        res += vector[j].ToString();

                    res += "\r\n";
                }
                AddOne(ref bl);
            }

            if (res == "")
                resBox.Text = "Данную функцию нельзя доопределить до линейной";
            else
                resBox.Text = res;
        }
    }
}
