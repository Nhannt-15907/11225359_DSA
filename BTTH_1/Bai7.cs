using System;
using System.Collections.Generic;
using System.Text;

namespace _11225359_TH_DSA_1
{
    // Bài 7: Đếm số chữ số của số nguyên dương
    // Có n = 0 --> Số chữ số = 0
    // => S0ChuSo(n) = SoChuSo(n / 10) + 1
    internal class Bai7
    {
        public int SoChuSo(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return SoChuSo(n / 10) + 1;
            }
        }
        public void HienThi(int So)
        {
            Console.WriteLine($"Số chữ số = {So}");
        }
    }
}
