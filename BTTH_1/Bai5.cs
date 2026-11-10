using System;
using System.Collections.Generic;
using System.Text;

namespace _11225359_TH_DSA_1
{
    // Bài 5: Tìm ước số lẻ lớn nhất của số nguyên dương n.
    // Nếu n % 2 == 1 thì khi đó UocLeMax(n) = n
    // => UocLeMax(n) = UocLeMax(n/2)
    internal class Bai5
    {
        public int UocLeMax(int n)
        {
            if (n % 2 == 1)
            {
                return n;
            }
            else
            {
                return UocLeMax(n / 2);
            }
        }
        public void HienThi(int ULLN)
        {
            Console.WriteLine($"Ước số lẻ lớn nhất = {ULLN}");
        }
    }
}
