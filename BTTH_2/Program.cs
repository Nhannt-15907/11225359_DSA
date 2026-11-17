using System.Text;

namespace _11225359_TH_DSA_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            /* Bài 1:
            Console.WriteLine("Bài 1: Cho n số nguyên dương a1, a1, a2, ..., an - 1.\r\n    a. Nhập từ bàn phím.\r\n    b. Hiển thị danh sách ra màn hình, các phần tử cách nhau 1 khoảng trống.\r\n    c. Chèn phần tử x vào vị trí k của dãy.");
            Bai1 test1 = new Bai1();
            test1.Nhap();
            test1.Nhap();
            test1.Nhap();
            test1.Nhap();
            test1.Nhap();
            test1.Hien_thi();
            */
            /* Bài 2
            Console.WriteLine("\r\n    Cho một danh sách lưu trữ thông tin về các nhân viên trong một công ty, thông tin gồm:\r\n    - Mã nhân viên\r\n    - Họ và tên\r\n    - Năm sinh (số nguyên)\r\n    - Phòng ban\r\n    - Lương cơ bản (số nguyên)\r\n    - Thưởng (số nguyên)\r\n    - Thực lĩnh (số nguyên, trong đó thực lĩnh = lương cơ bản + thưởng)\r\n    Hãy thực hiện các yêu cầu sau:\r\n    a. Tính tổng thực lĩnh tháng của tất cả nhân viên trong công ty.\r\n    b. In danh sách những nhân viên có mức lương cơ bản thấp nhất.\r\n    c. Đếm số lượng nhân viên có mức thưởng >= 1200000.\r\n    d. In danh sách các nhân viên tăng dần theo phòng ban, nếu phòng ban trùng nhau thì giảm dần theo mã nhân viên.\r\n    e. Cập nhật tăng lương của tất cả các nhân viên lên 5%\r\n");
            Bai2 test2 = new Bai2();
            test2.Nhap();
            Console.WriteLine("Danh sách nhân viên vừa nhập:");
            test2.Hien_thi_ds();
            Console.WriteLine("Tổng thực lĩnh:");
            test2.Tinh_tong_thuc_linh();
            Console.WriteLine("Nhân viên có lương cơ bản thấp nhất:");
            test2.In_nv_luong_thap_nhat();
            Console.WriteLine("Số lượng nhân viên thưởng >= 1200000:");
            test2.Dem_thuong();
            Console.WriteLine("Danh sách sắp xếp theo phòng ban và mã nhân viên:");
            test2.Sap_xep_phong_ban();
            test2.Tang_luong();
            Console.WriteLine("Danh sách sau khi tăng lương 5%:");
            test2.Hien_thi_ds();
            */
            /* Bài 3 
            Ma_tran mt = new Ma_tran();
            mt.Nhap();
            Console.WriteLine("Ma trận vừa nhập:");
            mt.Hien_thi();
            Console.WriteLine("Tổng các phần tử:");
            mt.Tinh_tong_ma_tran();
            Console.WriteLine("Giá trị dương nhỏ nhất:");
            mt.Tim_duong_nho_nhat();
            Console.WriteLine("Tổng đường chéo phụ:");
            mt.Tinh_tong_cheo_phu();
            Console.WriteLine("Đường chéo chính có tăng hay không:");
            mt.Kiem_tra_cheo_chinh();
            */
            /* Bài 4
            Console.WriteLine("Bài 4: Cho một danh sách liên kết đơn (có pHead chứa địa chỉ nút đầu tiên của danh sách), mỗi nút là một số nguyên dương.\r\n    a. Đếm xem trong danh sách có bao nhiêu số bằng x ?\r\n    b. Tìm phần tử dương nhỏ nhất trong danh sách.\r\n    c. Xóa phần tử x xuất hiện đầu tiên trong danh sách.");
            Bai4 list = new Bai4();
            list.Nhap();
            list.Hien_thi();
            Console.Write("Nhập x để đếm: ");
            int xDem = int.Parse(Console.ReadLine());
            list.Dem_so_x(xDem);
            list.Tim_duong_nho_nhat();
            Console.Write("Nhập x cần xóa: ");
            int xXoa = int.Parse(Console.ReadLine());
            list.Xoa_dau_tien(xXoa);
            list.Hien_thi();
            */
            /* Bài 5 */
            Console.WriteLine("Bài 5: Cho một danh sách liên kết đơn l, mỗi nút là một số nguyên.\r\n    a. Tìm phần tử lớn nhất danh sách l.\r\n    b. Tính tổng các phần tử của danh sách l.\r\n    c. Đếm xem trong danh sách l có bao nhiêu số nguyên tố?\r\n    d. Đếm xem trong danh sách có bao nhiêu số âm? bao nhiêu số bằng 0? bao nhiêu số dương ?\r\n    e. Đếm xem trong danh sách có bao nhiêu số bằng x ?\r\n    f. Tìm phần tử dương nhỏ nhất trong danh sách.");
            Bai5 bai5 = new Bai5();
            bai5.Nhap();
            bai5.Hien_thi();
            Console.WriteLine("Phần tử lớn nhất:");
            bai5.Tim_max();
            Console.WriteLine("Tổng các phần tử:");
            bai5.Tinh_tong();
            Console.WriteLine("Số lượng số nguyên tố:");
            bai5.Dem_so_nguyen_to();
            Console.WriteLine("Số lượng (âm, không, dương):");
            bai5.Dem_am_khong_duong();
            Console.Write("Nhập x để đếm: ");
            int x = int.Parse(Console.ReadLine());
            bai5.Dem_so_x(x);
            Console.WriteLine("Phần tử dương nhỏ nhất:");
            bai5.Tim_duong_nho_nhat();
        }
    }
}
