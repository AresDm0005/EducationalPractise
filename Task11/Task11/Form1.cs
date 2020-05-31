using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Task11
{
    public partial class Task11 : Form
    {
        private ErrorProvider incorrectInput;
        private Random rnd;

        public Task11()
        {
            InitializeComponent();
            incorrectInput = new ErrorProvider();
            incorrectInput.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            rnd = new Random();
        }

        private string Solve(string inp)
        {
            string txt = "";
            for (int i = 0; i < inp.Length / 3; i++)
                if (inp[i * 3] == inp[i * 3 + 1] || inp[i * 3] == inp[i * 3 + 2])
                    txt += inp[i * 3];
                else
                    txt += inp[i * 3 + 1];

            return txt;
        }

        private void rndButton_Click(object sender, EventArgs e)
        {
            string txt = "";
            int length = rnd.Next(3, 15) * 3;

            for (int i = 0; i < length; i++)
                txt += rnd.Next(0, 2);

            inputBox.Text = txt;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = Solve(inputBox.Text);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[01]") && e.KeyChar != 8)            
                e.Handled = true;            
        }

        private void inputBox_Validating(object sender, CancelEventArgs e)
        {
            int length = ((TextBox)sender).Text.Length;
            if(length % 3 != 0)
            {
                e.Cancel = true;
                inputBox.SelectAll();
                incorrectInput.SetError((Control)sender, $"Длина входящего сообщения должна быть кратна 3\nТекущая длина: {length}");
            }
        }

        private void inputBox_Validated(object sender, EventArgs e)
        {
            incorrectInput.SetError((Control)sender, String.Empty);
        }
    }
}
