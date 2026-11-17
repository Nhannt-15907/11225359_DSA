using System;
using System.Collections.Generic;
using System.Text;

namespace _11225359_TH_DSA_2
{
    /*
    Bài 5: Cho một danh sách liên kết đơn l, mỗi nút là một số nguyên.
    a. Tìm phần tử lớn nhất danh sách l.
    b. Tính tổng các phần tử của danh sách l.
    c. Đếm xem trong danh sách l có bao nhiêu số nguyên tố?
    d. Đếm xem trong danh sách có bao nhiêu số âm? bao nhiêu số bằng 0? bao nhiêu số dương ?
    e. Đếm xem trong danh sách có bao nhiêu số bằng x ?
    f. Tìm phần tử dương nhỏ nhất trong danh sách.
     */
    class Nut_So_Nguyen
    {
        public int data;
        public Nut_So_Nguyen pTiep;

        public Nut_So_Nguyen(int x)
        {
            data = x;
            pTiep = null;
        }
    }
    class Bai5
    {
        private Nut_So_Nguyen pHead;

        public Bai5()
        {
            pHead = null;
        }

        public void Them_cuoi(int x)
        {
            Nut_So_Nguyen p = new Nut_So_Nguyen(x);
            if (pHead == null)
            {
                pHead = p;
            }
            else
            {
                Nut_So_Nguyen pCur = pHead;
                while (pCur.pTiep != null)
                {
                    pCur = pCur.pTiep;
                }
                pCur.pTiep = p;
            }
        }
        public void Nhap()
        {
            Console.Write("Số lượng: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                for (int i = 0; i < n; i++)
                {
                    string test = Console.ReadLine();
                    try
                    {
                        int so = int.Parse(test);
                        Them_cuoi(so);
                    }
                    catch (Exception)
                    {
                        i--;
                    }
                }
            }
        }
        public void Hien_thi()
        {
            Nut_So_Nguyen pCur = pHead;
            while (pCur != null)
            {
                Console.Write($"{pCur.data} ");
                pCur = pCur.pTiep;
            }
            Console.WriteLine();
        }
        private bool La_so_nguyen_to(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public void Tim_max()
        {
            if (pHead == null) return;

            int maxVal = pHead.data;
            Nut_So_Nguyen pCur = pHead.pTiep;
            while (pCur != null)
            {
                if (pCur.data > maxVal)
                {
                    maxVal = pCur.data;
                }
                pCur = pCur.pTiep;
            }
            Console.WriteLine(maxVal);
        }
        public void Tinh_tong()
        {
            int tong = 0;
            Nut_So_Nguyen pCur = pHead;
            while (pCur != null)
            {
                tong = tong + pCur.data;
                pCur = pCur.pTiep;
            }
            Console.WriteLine(tong);
        }
        public void Dem_so_nguyen_to()
        {
            int dem = 0;
            Nut_So_Nguyen pCur = pHead;
            while (pCur != null)
            {
                if (La_so_nguyen_to(pCur.data))
                {
                    dem = dem + 1;
                }
                pCur = pCur.pTiep;
            }
            Console.WriteLine(dem);
        }
        public void Dem_am_khong_duong()
        {
            int am = 0;
            int khong = 0;
            int duong = 0;

            Nut_So_Nguyen pCur = pHead;
            while (pCur != null)
            {
                if (pCur.data < 0)
                {
                    am = am + 1;
                }
                else if (pCur.data == 0)
                {
                    khong = khong + 1;
                }
                else
                {
                    duong = duong + 1;
                }
                pCur = pCur.pTiep;
            }
            Console.WriteLine($"{am} {khong} {duong}");
        }
        public void Dem_so_x(int x)
        {
            int dem = 0;
            Nut_So_Nguyen pCur = pHead;
            while (pCur != null)
            {
                if (pCur.data == x)
                {
                    dem = dem + 1;
                }
                pCur = pCur.pTiep;
            }
            Console.WriteLine(dem);
        }
        public void Tim_duong_nho_nhat()
        {
            if (pHead == null) return;

            int minDuong = -1;
            Nut_So_Nguyen pCur = pHead;
            while (pCur != null)
            {
                if (pCur.data > 0)
                {
                    if (minDuong == -1 || pCur.data < minDuong)
                    {
                        minDuong = pCur.data;
                    }
                }
                pCur = pCur.pTiep;
            }

            if (minDuong != -1)
            {
                Console.WriteLine(minDuong);
            }
        }
    }
}