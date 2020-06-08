using System;

namespace Task7
{
    public class Solver
    {
        private int[] vector;
        private int N;

        public Solver(int[] vec)
        {
            vector = new int[vec.Length];
            Array.Copy(vec, vector, vec.Length);

            N = vec.Length;
        }

        private int[,] Zhegalkin()
        {
            int[,] mat = new int[N, N];

            for (int i = 0; i < N; i++)
                mat[i, 0] = vector[i];

            for (int i = 1; i < N; i++)
                for (int j = 0; j < N - i; j++)
                    mat[j, i] = (mat[j, i - 1] + mat[j + 1, i - 1]) % 2;

            return mat;
        }

        public bool IsLinear() 
        {
            int[,] mat = Zhegalkin();
            bool ok = true;

            int pow = 1;
            for (int i = 1; i < N && ok; i++)
            {
                if (i == pow)
                    pow *= 2;
                else if (mat[0, i] == 1)
                    ok = false;
            }

            return ok;
        }
    }
}
