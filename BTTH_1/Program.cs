using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _11225359_TH_DSA_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("----------- MENU --------------");
                Console.WriteLine("Vui lòng nhấn phím để thực hiện thao tác với các bài:");
                Console.WriteLine("Phím 1: Bài 1");
                Console.WriteLine("Phím 2: Bài 2");
                Console.WriteLine("Phím 3: Bài 3");
                Console.WriteLine("Phím 4: Bài 4");
                Console.WriteLine("Phím 5: Bài 5");
                Console.WriteLine("Phím 6: Bài 6");
                Console.WriteLine("Phím 7: Bài 7");
                Console.WriteLine("Phím 8: Bài 8");
                Console.WriteLine("Phím bất kỳ: Dừng chương trình");
                ConsoleKeyInfo phim = Console.ReadKey(true); // Dùng true để không hiển thị nội dung phím khi nhấn
                switch (phim.Key)
                {
                // Đây chỉ là test Demo và chưa có bắt lỗi
                    case ConsoleKey.D1:
                        // Bài 1 
                        Console.WriteLine("---- Đã chọn bài 1 ----");
                        Console.WriteLine(" Tính S(n) = 1 + 2 + 3 + ... + (n - 1) + n");
                        Console.Write("Hãy nhập số để tính: ");
                        int nhap1 = int.Parse(Console.ReadLine());
                        Bai1 test1 = new Bai1();
                        test1.HienThi(test1.S(nhap1));
                        Console.WriteLine("Nhấn bất kỳ để quay về Menu");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    case ConsoleKey.D2:
                        // Bài 2
                        Console.WriteLine("---- Đã chọn bài 2 ----");
                        Console.WriteLine("Tính S(n) = 1 + 2^2 + 3^2 + ... + (n - 1)^2 + n^2");
                        Console.Write("Hãy nhập số để tính: ");
                        int nhap2 = int.Parse(Console.ReadLine());
                        Bai2 test2 = new Bai2();
                        test2.S(nhap2);
                        test2.HienThi(test2.S(nhap2));
                        Console.WriteLine("Nhấn bất kỳ để quay về Menu");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    case ConsoleKey.D3:
                        // Bài 3
                        Console.WriteLine("---- Đã chọn bài 3 ----");
                        Console.WriteLine("Tính S(n) = 1 + 1/2 + 1/3 + ... + 1/(n - 1) + 1/n");
                        Console.Write("Hãy nhập số để tính: ");
                        int nhap3 = int.Parse(Console.ReadLine());
                        Bai3 test3 = new Bai3();
                        test3.S(nhap3);
                        test3.HienThi((float)test3.S(nhap3));
                        Console.WriteLine("Nhấn bất kỳ để quay về Menu");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    case ConsoleKey.D4:
                        // Bài 4
                        Console.WriteLine("---- Đã chọn bài 4 ----");
                        Console.WriteLine("Tính S(x, n) = x^n");
                        Console.Write("Hãy nhập x để tính: ");
                        int nhap4_1 = int.Parse(Console.ReadLine());
                        Console.Write("Hãy nhập m để tính: ");
                        int nhap4_2 = int.Parse(Console.ReadLine());
                        Bai4 test4 = new Bai4();
                        test4.HienThi((int)test4.S(nhap4_1, nhap4_2));
                        Console.WriteLine("Nhấn bất kỳ để quay về Menu");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    case ConsoleKey.D5:
                        // Bài 5
                        Console.WriteLine("---- Đã chọn bài 5 ----");
                        Console.WriteLine("Tìm ước số lẻ lớn nhất của số nguyên dương n");
                        Console.Write("Hãy nhập số để tính: ");
                        int nhap5 = int.Parse(Console.ReadLine());
                        Bai5 test5 = new Bai5();
                        test5.HienThi(test5.UocLeMax(nhap5));
                        Console.WriteLine("Nhấn bất kỳ để quay về Menu");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    case ConsoleKey.D6:
                        // Bài 6
                        Console.WriteLine("---- Đã chọn bài 6 ----");
                        Console.WriteLine("Tìm ước số chung lớn nhất của số nguyên dương a, b");
                        Console.Write("Hãy nhập a để tính: ");
                        int nhap6_a = int.Parse(Console.ReadLine());
                        Console.Write("Hãy nhập b để tính: ");
                        int nhap6_b = int.Parse(Console.ReadLine());
                        Bai6 test6 = new Bai6();
                        test6.HienThi(test6.UCLN(nhap6_a, nhap6_b));
                        Console.WriteLine("Nhấn bất kỳ để quay về Menu");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    case ConsoleKey.D7:
                        // Bài 7
                        Console.WriteLine("---- Đã chọn bài 7 ----");
                        Console.WriteLine("Đếm số chữ số của số nguyên dương");
                        Console.Write("Hãy nhập số để tính: ");
                        int nhap7 = int.Parse(Console.ReadLine());
                        Bai7 test7 = new Bai7();
                        test7.HienThi(test7.SoChuSo(nhap7));
                        Console.WriteLine("Nhấn bất kỳ để quay về Menu");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    case ConsoleKey.D8:
                        // Bài 8
                        Console.WriteLine("---- Đã chọn bài 8 ----");
                        Console.WriteLine("???");
                        Console.Write("Hãy nhập a để tính: ");
                        int nhap8_a = int.Parse(Console.ReadLine());
                        Console.Write("Hãy nhập n để tính: ");
                        int nhap8_n = int.Parse(Console.ReadLine());
                        Bai8 test8 = new Bai8();
                        test8.HienThi((double)test8.Can(nhap8_a,nhap8_n));
                        Console.WriteLine("Nhấn bất kỳ để quay về Menu");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    default:
                        break;
                }
                break;
            }
        }
    }
}
