using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Task5
{
    public partial class Task5Form : Form
    {
        private Random rand = new Random();
        private double[,] matr = new double[10, 10];

        public Task5Form()
        {
            InitializeComponent();
        }

        private void Task5Form_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < matrixPanel.Controls.Count; i++)
            {
                if (!(matrixPanel.Controls[i] is TextBox)) 
                    continue;

                ((TextBox)matrixPanel.Controls[i]).KeyPress += new KeyPressEventHandler(Elements_KeyPress);
            }

            for (int i = 0; i < resultPanel.Controls.Count; i++)
            {
                if (!(resultPanel.Controls[i] is TextBox))
                    continue;

                TextBox text = (TextBox)resultPanel.Controls[i];
                text.ReadOnly = true;
                text.Text = "-";
            }
        }

        private void Elements_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d,\-]") && e.KeyChar != 8)
                e.Handled = true;
        }

        private void rndButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < matrixPanel.Controls.Count; i++)
                matrixPanel.Controls[i].Text = (rand.Next(-100, 100) * 0.1 ).ToString();
        }

        private bool HandleInputs()
        {
            bool ok = true;
            string error = "";
            for (int i = 0; i < matrixPanel.Controls.Count && ok; i++)
            {
                ok = double.TryParse(matrixPanel.Controls[i].Text, out matr[i / 10, i % 10]);

                if (!ok)
                    error = $"Данные в строке {i / 10 + 1}, столбце {i % 10 + 1} введены некорректно";
            }

            if (!ok)
                MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            return ok;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (!HandleInputs())
                return;

            for(int i = 0; i < matr.GetLength(0); i++)
            {
                if (matr[i, i] >= 0)
                    resultPanel.Controls[i].Text = "Усл. не вып.";
                else
                {
                    double sum = 0;
                    for (int j = 0; j < matr.GetLength(1); j++)
                        sum += matr[i, j];

                    resultPanel.Controls[i].Text = sum.ToString();
                }
            }
        }
    }
}
