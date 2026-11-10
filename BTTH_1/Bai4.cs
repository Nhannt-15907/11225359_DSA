using System;
using System.Collections.Generic;
using System.Text;

namespace _11225359_TH_DSA_1
{
    // Bài 4: Tính S(x, n) = x^n
    // Có x^n = x^(n - 1) * x
    // => S(x, n) = S(x, n - 1) * x
    internal class Bai4
    {
        public double S(int x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (x == 0)
            {
                return 0;
            }
            else
            {
                return S(x, n - 1) * x;
            }
        }
        public void HienThi(int So)
        {
            Console.WriteLine($"Tích lũy = {So}");
        }
    }
}
