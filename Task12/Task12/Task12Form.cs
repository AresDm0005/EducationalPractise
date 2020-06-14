using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task12
{
    public partial class Task12Form : Form
    {
        private Random rand = new Random();
        private List<int[]> insertion;
        private List<int[]> radix;
        
        private byte RadixDigit(int num, int dig)
        {
            byte res = 0;
            while(num > 0 && dig > 0)
            {
                res = (byte)(num % 10); 
                num /= 10; 
                dig--;
            }

            return (dig > 0) ? (byte)0 : res;
        }

        private int[] RadixSort(int[] arr, out int transf, out int comp)
        {
            transf = 0;
            comp = 0;
            // Максимальное число разрядов у чисел в массиве
            int digits = arr.Max(item => item.ToString().Length);
            
            int k = 10;
            int N = arr.Length;

            // Вспомогательный мас. для нужного порябка элем.
            int[] tmp = new int[N];
            // Подсчет количества раз цифра использованна
            int[] digs = new int[k];
            // i-ые цифры элементов массива
            byte[] d = new byte[N];

            for(int i = 1; i < digits; i++)
            {
                for (int j = 0; j < k; j++)
                    digs[j] = 0;

                for (int j = 0; j < N; j++)
                {
                    d[j] = RadixDigit(arr[j], i);
                    digs[d[j]]++;
                }

                int count = 0;
                for(int j = 0; j < k; j++)
                {
                    int t = digs[j];
                    digs[j] = count;
                    count += t;
                }

                for(int j = 0; j < N; j++)
                {
                    if (digs[d[j]] != j)
                        transf++;

                    tmp[digs[d[j]]] = arr[j];
                    digs[d[j]]++;
                }

                for (int j = 0; j < N; j++)
                    arr[j] = tmp[j];
            }

            return arr;
        }

        private int[] InsertionSort(int[] arr, out int transf, out int comp)
        {
            transf = 0;
            comp = 0;

            int N = arr.Length;
            for(int i = 1; i < N; i++)
            {
                int j = i - 1;
                while(j >= 0 && arr[j] > arr[j + 1])
                {
                    transf++;
                    comp++;

                    var tmp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j] = tmp;
                    j--;
                }
                comp++;
            }

            return arr;
        }

        public Task12Form()
        {
            InitializeComponent();
        }

        private void Task12Form_Load(object sender, EventArgs e)
        {
            
        }

        private void rndButton_Click(object sender, EventArgs e)
        {
            //int size = rand.Next(10, 50);
            int size = 20;
            string txt = "";

            for (int i = 0; i < size; i++)
                txt += rand.Next(-50, 51).ToString() + " ";

            arrayBox.Text = txt;
        }

        private bool HandleInput(out string error, ref int[] arr)
        {
            error = string.Empty;

            if (arrayBox.Text == "") 
            {
                error += "Элементы массива не были введены";
                return false;
            }

            string[] str = arrayBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            arr = new int[str.Length];

            for (int i = 0; i < str.Length; i++)
                if (!int.TryParse(str[i], out arr[i]))
                    error += $"Элемент {i + 1} был введен некорректно\n";

            return error == string.Empty;
        }

        private int[] Copy(ref int[] arr)
        {
            int[] array = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
                array[i] = arr[i];

            return array;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            string error;
            int[] arr = null;
            if(!HandleInput(out error, ref arr))
            {
                MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK);
                return;
            }

            insertion = new List<int[]>(3);
            radix = new List<int[]>(3);

            // Ascending
            Array.Sort(arr, (int a, int b) => a - b);

            insertion.Add(Copy(ref arr));
            radix.Add(Copy(ref arr));

            // Descending
            Array.Sort(arr, (int a, int b) => b - a);

            insertion.Add(Copy(ref arr));
            radix.Add(Copy(ref arr));

            // Random
            for (int i = arr.Length - 1; i > 0; i--)
            {
                int j = rand.Next(0, i + 1);
                int tmp = arr[i];
                arr[i] = arr[j];
                arr[j] = tmp;
            }

            insertion.Add(Copy(ref arr));
            radix.Add(Copy(ref arr));

            ascenBox.Text = radix[0].Select(item => item.ToString() + " ").Aggregate((a,b) => a + b);
            descenBox.Text = radix[1].Select(item => item.ToString() + " ").Aggregate((a, b) => a + b);
            randBox.Text = radix[2].Select(item => item.ToString() + " ").Aggregate((a, b) => a + b);

            int[] res = new int[4];
            for(int i = 0; i < 3; i++)
            {
                RadixSort(radix[i], out res[0], out res[1]);
                InsertionSort(insertion[i], out res[2], out res[3]);

                ((Label)Controls.Find($"radTrans{i + 1}", true)[0]).Text = res[0].ToString();
                ((Label)Controls.Find($"radComp{i + 1}", true)[0]).Text = res[1].ToString();
                ((Label)Controls.Find($"insTrans{i + 1}", true)[0]).Text = res[2].ToString();
                ((Label)Controls.Find($"insComp{i + 1}", true)[0]).Text = res[3].ToString();
            }
        }
    }
}
