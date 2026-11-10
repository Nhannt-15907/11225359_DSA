using System;
using System.Collections.Generic;
using System.Text;

namespace _11225359_TH_DSA_1
{
    // Bài 1: Tính S(n) = 1 + 2 + 3 + ... + (n - 1) + n
    // --> S(n - 1) = 1 + 2 + 3 + ... + (n - 1)
    // => S(n) = S(n - 1) + n
    public class Bai1
    {
        public int S(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return S(n - 1) + n;
            } 
        }
        public void HienThi(int So)
        {
            Console.WriteLine("Tổng = {0}",So);
        }
    }
}
