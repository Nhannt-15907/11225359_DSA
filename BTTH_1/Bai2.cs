using System;
using System.Collections.Generic;
using System.Text;

namespace _11225359_TH_DSA_1
{
    // Bài 2: Tính S(n) = 1 + 2^2 + 3^2 + ... + (n - 1)^2 + n^2
    // --> S(n - 1) = 1^2 + 2^2 + 3^2 + ... + (n - 1)^2
    // => S(n) = S(n - 1) + n^2
    internal class Bai2
    {
        public int S(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return S(n - 1) + n * n;
            }
        }
        public void HienThi(int So)
        {
            Console.WriteLine($"Tổng bình phương = {So}");
        }
    }
}
