using System;
using System.Collections.Generic;
using System.Text;

namespace _11225359_TH_DSA_1
{
    // Bài 6: Tìm ước số chung lớn nhất của số nguyên dương a, b.
    // Nếu a % b == 0 thì khi đó UCLN(a, b) = b
    // Nếu a % b khác 0 -> UCLN(a, b) = UCLN(b, a % b) 
    internal class Bai6
    {
        public int UCLN(int a, int b)
        {
            if (a > b)
            {
                if (a % b == 0)
                {
                    return b;
                }
                else
                {
                    return UCLN(b, a % b);
                }
            }
            else
            {
                int c = a;
                a = b;
                b = c;
                return UCLN(a, b);
            } 
            
        }
        public void HienThi(int UCLN)
        {
            Console.WriteLine($"Ước số chung lớn nhất = {UCLN}");
        }
    }
}
