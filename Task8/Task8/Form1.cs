using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Task8
{
    public partial class Form1 : Form
    {
        private static List<List<int>> graph;
        private static List<int> result;
        private static bool[] used;
        private static int[] d, up;
        private static int time;

        static void dfs(int v, int p = -1)
        {
            used[v] = true;
            d[v] = up[v] = time++;
            int child = 0;
            for(int i = 0; i< graph[v].Count; i++)
            {
                int to = graph[v][i];
                if (to == p) continue;
                
                if (used[to]) up[v] = Math.Min(up[v], d[to]);
                else
                {
                    dfs(to, v);
                    up[v] = Math.Min(up[v], up[to]);
                    if ((up[to] >= d[v]) && p != -1) 
                        result.Add(v);

                    child++;
                }
            }
            if (child > 1 && p == -1) result.Add(v);
        }


        public Form1()
        {
            InitializeComponent();
        }
        
        private bool HandleSizes(out string error)
        {
            error = "";

            if (verBox.Text == "" || rebBox.Text == "")
            {
                error = "Не введено количество вершин или ребер!";
                return false;
            }

            int N = int.Parse(verBox.Text);
            int M = int.Parse(rebBox.Text);

            if (N < 1 || N > 20 || M < 0 || M > 20)
            {
                error = "Количество вершин и ребер должно быть от 1 до 20";
                return false;
            }

            if (N * (N - 1) / 2 < M)
            {
                error = $"Слишком много ребер для такого числа вершин. Полный граф для графа с количеством вершин: {N} равно {N * (N - 1) / 2}";
                return false;
            }

            return true;
        }

        private bool HandleInputs(out int[,] mat, out string error)
        {
            mat = null;
            if (!HandleSizes(out error))
                return false;

            int N = int.Parse(verBox.Text);
            int M = int.Parse(rebBox.Text);

            if(matrBox.Text == "")
            {
                error += "Не введена матрица";
                return false;
            }

            mat = new int[N, M];
            string[] tmp = matrBox.Text.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            if(tmp.Length != N)
            {
                error = "Число строк не совпадает с введенным числом вершин";
                return false;
            }

            for(int i = 0; i < N; i++)
            {
                string[] line = tmp[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int k = line.Length;

                if (k != M)
                    error += $"Число элементов в строке {i+1} не соответствует введенному числу ребер\n";

                for(int j = 0; j < Math.Min(M, k); j++)
                {
                    bool ok = int.TryParse(line[j], out mat[i, j]);
                    if (!ok)
                        error += $"Строка {i + 1}, столбец {j + 1} некорректно введено число!\n";
                    else if (mat[i, j] > 1)
                        error += $"Строка {i + 1}, столбец {j + 1}: элементы матрицы должны быть равны 0 или 1\n";
                }
            }

            if(error == "")
            {
                for(int i = 0; i < M; i++)
                {
                    int ones = 0;
                    for(int j = 0; j < N; j++)                    
                        if (mat[j, i] == 1)
                            ones++;

                    if (ones != 2)
                        error += $"В столбце {i} расположено {ones} единиц, когда должно быть ровно 2\n";
                }
            }

            return error == "";
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            int[,] matr;
            string error;
            if(!HandleInputs(out matr, out error))
            {
                MessageBox.Show(error, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int N = matr.GetLength(0);
            int M = matr.GetLength(1);
            graph = new List<List<int>>(N);
            for (int i = 0; i < N; i++)
                graph.Add(new List<int>(M));

            // Список смежности
            for(int i = 0; i < M; i++)
            {
                int[] tmp = new int[2];
                int ind = 0;
                for (int j = 0; j < N && ind < 2; j++)
                    if (matr[j, i] == 1)                    
                        tmp[ind++] = j;

                graph[tmp[0]].Add(tmp[1]);
                graph[tmp[1]].Add(tmp[0]);
            }

            d = new int[N];
            up = new int[N];
            used = new bool[N];
            result = new List<int>(N);

            time = 1;
            for (int i = 0; i < N; i++)
                if (!used[i])
                    dfs(i);

            if (result.Count == 0)
                resBox.Text = "Точек сочленения не найдено";
            else
            {
                string txt = "";
                result.Sort();
                foreach (int it in result)
                    txt += (it+1).ToString() + " ";
                resBox.Text = $"Найдено {result.Count} точек сочленения\r\nТочки сочленения:\r\n{txt}";
            }
        }

        private void matrBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[01\s\b\r]"))
                e.Handled = true;
        }

        private void rebBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d\b]"))
                e.Handled = true;
        }
    }
}
