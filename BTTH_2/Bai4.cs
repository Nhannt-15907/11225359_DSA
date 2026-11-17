using System;
using System.Collections.Generic;
using System.Text;

namespace _11225359_TH_DSA_2
{
    /*
    Bài 4: Cho một danh sách liên kết đơn (có pHead chứa địa chỉ nút đầu tiên của danh sách), mỗi nút là một số nguyên dương.
    a. Đếm xem trong danh sách có bao nhiêu số bằng x ?
    b. Tìm phần tử dương nhỏ nhất trong danh sách.
    c. Xóa phần tử x xuất hiện đầu tiên trong danh sách.
    */
    class Nut
    {
        public int data;
        public Nut pTiep;

        public Nut(int x)
        {
            data = x;
            pTiep = null;
        }
    }
    class Bai4
    {
        private Nut pHead;

        public Bai4()
        {
            pHead = null;
        }

        public void Them_cuoi(int x)
        {
            Nut p = new Nut(x);
            if (pHead == null)
            {
                pHead = p;
            }
            else
            {
                Nut pCur = pHead;
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
                    if (Bai1.Ktra_so(test))
                    {
                        int so = int.Parse(test);
                        Them_cuoi(so);
                    }
                    else
                    {
                        i--;
                    }
                }
            }
        }

        public void Hien_thi()
        {
            Nut pCur = pHead;
            while (pCur != null)
            {
                Console.Write($"{pCur.data} ");
                pCur = pCur.pTiep;
            }
            Console.WriteLine();
        }
        public void Dem_so_x(int x)
        {
            int dem = 0;
            Nut pCur = pHead;
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
            if (pHead == null)
            {
                return;
            }

            int minDuong = -1;
            Nut pCur = pHead;
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
        public void Xoa_dau_tien(int x)
        {
            if (pHead == null)
            {
                return;
            }

            if (pHead.data == x)
            {
                pHead = pHead.pTiep;
                return;
            }

            Nut pCur = pHead;
            while (pCur.pTiep != null)
            {
                if (pCur.pTiep.data == x)
                {
                    pCur.pTiep = pCur.pTiep.pTiep;
                    return;
                }
                pCur = pCur.pTiep;
            }
        }
    }
}