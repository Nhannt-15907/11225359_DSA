using System;
using System.Collections.Generic;
using System.Text;

namespace _11225359_TH_DSA_2
{
    /*
    Bài 3: Cho ma trận vuông n dòng và n cột; các phần tử là các số nguyên (0 <= n <= 100). Viết các hàm thực hiện các yêu cầu sau:
    a. Tính tổng tất cả các phần tử của ma trận.
    b. Tìm giá trị dương nhỏ nhất của ma trận.
    c. Tính tổng các phần tử nằm trên đường chéo phụ.
    d. Kiểm tra xem các phần tử nằm trên đường chéo chính có tăng hay không (theo chiều từ góc trên bên trái xuống góc dưới bên phải)
     */
    class Ma_tran
    {
        private int[,] matran;
        private int n;

        public int N
        {
            get
            {
                return n;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    n = value;
                    matran = new int[n, n];
                }
                else
                {
                    throw new Exception("Kích thước n phải từ 0 đến 100!");
                }
            }
        }
        public void Nhap()
        {
            while (true)
            {
                try
                {
                    Console.Write("Nhập cấp của ma trận vuông n (0 <= n <= 100): ");
                    string test = Console.ReadLine();
                    if (Bai1.Ktra_so(test))
                    {
                        N = int.Parse(test);
                    }
                    else if (test == "0")
                    {
                        N = 0;
                        break;
                    }
                    else
                    {
                        throw new Exception("Vui lòng nhập số nguyên hợp lệ!");
                    }

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write($"Phần tử [{i},{j}]: ");
                            string val = Console.ReadLine();
                            try
                            {
                                matran[i, j] = int.Parse(val);
                            }
                            catch (Exception)
                            {
                                throw new Exception("Giá trị phần tử phải là số nguyên!");
                            }
                        }
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public void Hien_thi()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matran[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        // a. Tính tổng tất cả các phần tử của ma trận
        public void Tinh_tong_ma_tran()
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tong = tong + matran[i, j];
                }
            }
            Console.WriteLine(tong);
        }
        // b. Tìm giá trị dương nhỏ nhất của ma trận
        public void Tim_duong_nho_nhat()
        {
            int minDuong = -1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matran[i, j] > 0)
                    {
                        if (minDuong == -1 || matran[i, j] < minDuong)
                        {
                            minDuong = matran[i, j];
                        }
                    }
                }
            }

            if (minDuong == -1)
            {
                Console.WriteLine("Không có số dương nào trong ma trận");
            }
            else
            {
                Console.WriteLine(minDuong);
            }
        }
        // c. Tính tổng các phần tử nằm trên đường chéo phụ
        public void Tinh_tong_cheo_phu()
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong = tong + matran[i, n - 1 - i];
            }
            Console.WriteLine(tong);
        }
        // d. Kiểm tra xem các phần tử nằm trên đường chéo chính có tăng hay không
        public void Kiem_tra_cheo_chinh()
        {
            if (n <= 1)
            {
                Console.WriteLine("True");
                return;
            }

            bool tang = true;
            for (int i = 0; i < n - 1; i++)
            {
                if (matran[i, i] >= matran[i + 1, i + 1])
                {
                    tang = false;
                    break;
                }
            }

            if (tang)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
    internal class Bai3
    {
    }
}