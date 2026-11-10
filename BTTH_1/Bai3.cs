using System;
using System.Collections.Generic;
using System.Text;

namespace _11225359_TH_DSA_1
{
    // Bài 3: Tính S(n) = 1 + 1/2 + 1/3 + ... + 1/(n - 1) + 1/n
    // --> S(n - 1) = 1 + 1/2 + 1/3 + ... + 1/(n - 1)
    // => S(n) = S(n - 1) + 1/n
    internal class Bai3
    {
        public double S(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return S(n - 1) + (double)1 / n;
            }
        }
        public void HienThi(float So)
        {
            Console.WriteLine($"Tổng thương = {So:f3}");
        }
    }
}
