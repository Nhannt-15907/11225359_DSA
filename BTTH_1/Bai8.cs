using System;
using System.Collections.Generic;
using System.Text;

namespace _11225359_TH_DSA_1
{
    // Bài 8: ???
    internal class Bai8
    {
        public double Can(int a, int n)
        {
            if (a == n)
            {
                return Math.Sqrt(n);
            }
            else
            {
                return Math.Sqrt(a + Can(a + 1, n));
            }
        }
        public void HienThi(double So)
        {
            Console.WriteLine($"Số chữ số = {So}");
        }
    }
}
