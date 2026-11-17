using System;
using System.Collections.Generic;
using System.Text;

namespace _11225359_TH_DSA_2
{
    /* Bài 1: Cho n số nguyên dương a1, a1, a2, ..., an - 1.
    a. Nhập từ bàn phím.
    b. Hiển thị danh sách ra màn hình, các phần tử cách nhau 1 khoảng trống.
    c. Chèn phần tử x vào vị trí k của dãy.
    */
    class Bai1
    {
        private DS_so ds = new DS_so();
        private static int gia_tri = 0;
        public void Nhap()
        {
            Console.Write("Số: ");
            string test = Console.ReadLine();
            test = test.Trim();
            if (Ktra_so(test))
            {
                int so = int.Parse(test);
                gia_tri++;
                Them_so(so);
            }
            else
            {
                Console.WriteLine("Vui lòng nhập số nguyên dương và không cách giữa các số");
            }
        }
        public static bool Ktra_so(string test)
        {
            try
            {
                int so = int.Parse(test);
                if (so <= 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void Them_so(int so)
        {
            if (gia_tri == 1)
            {
                int[] dsn = new int[5];
                dsn[0] = so;
                ds.Ds_so_new = dsn;
            }
            else
            {
                if (gia_tri > ds.Ds_so_new.Length)
                {
                    int pt_so = ds.Ds_so_new.Length + 5;
                    int[] dsn = new int[pt_so];
                    for (int i = 0; i < ds.Ds_so_new.Length; i++)
                    {
                        dsn[i] = ds.Ds_so_new[i];
                    }
                    ds.Ds_so_old = ds.Ds_so_new;
                    ds.Ds_so_new = dsn;
                }
                ds.Ds_so_new[gia_tri - 1] = so;
            }
        }
        public void Hien_thi()
        {
            for (int i = 0; i < gia_tri; i++)
            {
                Console.Write($"{ds.Ds_so_new[i]} ");
            }
        }
    }
    class DS_so
    {
        public int[] Ds_so_old;
        public int[] Ds_so_new;
    }
}
