using System;
using System.Collections.Generic;
using System.Text;

namespace _11225359_TH_DSA_2
{
    /*
    Cho một danh sách lưu trữ thông tin về các nhân viên trong một công ty, thông tin gồm:
    - Mã nhân viên
    - Họ và tên
    - Năm sinh (số nguyên)
    - Phòng ban
    - Lương cơ bản (số nguyên)
    - Thưởng (số nguyên)
    - Thực lĩnh (số nguyên, trong đó thực lĩnh = lương cơ bản + thưởng)
    Hãy thực hiện các yêu cầu sau:
    a. Tính tổng thực lĩnh tháng của tất cả nhân viên trong công ty.
    b. In danh sách những nhân viên có mức lương cơ bản thấp nhất.
    c. Đếm số lượng nhân viên có mức thưởng >= 1200000.
    d. In danh sách các nhân viên tăng dần theo phòng ban, nếu phòng ban trùng nhau thì giảm dần theo mã nhân viên.
    e. Cập nhật tăng lương của tất cả các nhân viên lên 5%
     */
    class Nhanvien
    {
        string manv, ho_ten, phong_ban;
        int namsinh, luong_cb, thuong;
        public string MaNV
        {
            get
            {
                return manv;
            }
            set
            {
                value = value.Trim();
                if (value == null || value == "")
                {
                    throw new Exception("Không được để trống giá trị");
                }
                else
                {
                    manv = value;
                }
            }
        }
        public string Ho_ten
        {
            get
            {
                return ho_ten;
            }
            set
            {
                value = value.Trim();
                if (value == null || value == "")
                {
                    throw new Exception("Không được để trống giá trị");
                }
                else
                {
                    ho_ten = value;
                }
            }
        }
        public string Nam_sinh
        {
            get
            {
                return namsinh.ToString();
            }
            set
            {
                value = value.Trim();
                value = value.Replace("/", "");
                if (value.Length == 8)
                {
                    int test = int.Parse(value);
                    namsinh = test;
                }
                else
                {
                    throw new Exception("Vui lòng nhập năm sinh theo định dạng DD/MM/YYYY");
                }
            }
        }
        public string Phong_ban
        {
            get
            {
                return phong_ban;
            }
            set
            {
                value = value.Trim();
                if (value == null || value == "")
                {
                    throw new Exception("Không được để trống giá trị");
                }
                else
                {
                    phong_ban = value;
                }
            }
        }
        public string Luong_cb
        {
            get
            {
                return luong_cb.ToString();
            }
            set
            {
                if (Bai1.Ktra_so(value))
                {
                    luong_cb = int.Parse(value);
                }
                else
                {
                    throw new Exception("Lương cơ bản phải lớn hơn 0!");
                }
            }
        }
        public int Luong_cb_Int
        {
            get
            {
                return luong_cb;
            }
            set
            {
                luong_cb = value;
            }
        }
        public string Thuong
        {
            get
            {
                return thuong.ToString();
            }
            set
            {
                bool kt = int.TryParse(value, out int so);
                if (kt)
                {
                    if (so < 0)
                    {
                        throw new Exception("Thưởng nhân viên không thể là số âm");
                    }
                    else
                    {
                        thuong = so;
                    }
                }
                else
                {
                    throw new Exception("Thưởng nhân viên phải là số nguyên dương hoặc bằng không");
                }
            }
        }
        public int Thuong_Int
        {
            get
            {
                return thuong;
            }
        }
        public int Thuc_linh
        {
            get
            {
                return luong_cb + thuong;
            }
        }
        public void Nhap_NV()
        {
            while (true)
            {
                try
                {
                    Console.Write("Mã nhân viên: ");
                    MaNV = Console.ReadLine();
                    Console.Write("Họ tên nhân viên: ");
                    Ho_ten = Console.ReadLine();
                    Console.Write("Năm sinh nhân viên: ");
                    Nam_sinh = Console.ReadLine();
                    Console.Write("Phòng ban nhân viên: ");
                    Phong_ban = Console.ReadLine();
                    Console.Write("Lương cơ bản nhân viên: ");
                    Luong_cb = Console.ReadLine();
                    Console.Write("Thưởng nhân viên: ");
                    Thuong = Console.ReadLine();
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
            Console.WriteLine($"{manv} {ho_ten} {namsinh} {phong_ban} {luong_cb} {thuong} {Thuc_linh}");
        }
    }
    class DS_NhanVien
    {
        public Nhanvien[] Ds_nv_old;
        public Nhanvien[] Ds_nv_new;
    }

    class Bai2
    {
        private DS_NhanVien dsnv = new DS_NhanVien();
        private static int so_luong_nv = 0;
        public void Them_NV(Nhanvien nv)
        {
            so_luong_nv++;
            if (so_luong_nv == 1)
            {
                Nhanvien[] dsn = new Nhanvien[5];
                dsn[0] = nv;
                dsnv.Ds_nv_new = dsn;
            }
            else
            {
                if (so_luong_nv > dsnv.Ds_nv_new.Length)
                {
                    int pt_so = dsnv.Ds_nv_new.Length + 5;
                    Nhanvien[] dsn = new Nhanvien[pt_so];
                    for (int i = 0; i < dsnv.Ds_nv_new.Length; i++)
                    {
                        dsn[i] = dsnv.Ds_nv_new[i];
                    }
                    dsnv.Ds_nv_old = dsnv.Ds_nv_new;
                    dsnv.Ds_nv_new = dsn;
                }
                dsnv.Ds_nv_new[so_luong_nv - 1] = nv;
            }
        }
        public void Nhap()
        {
            Console.Write("Số lượng: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                for (int i = 0; i < n; i++)
                {
                    Nhanvien nv = new Nhanvien();
                    nv.Nhap_NV();
                    Them_NV(nv);
                }
            }
        }
        public void Hien_thi_ds()
        {
            for (int i = 0; i < so_luong_nv; i++)
            {
                dsnv.Ds_nv_new[i].Hien_thi();
            }
        }
        public void Tinh_tong_thuc_linh()
        {
            int tong = 0;
            for (int i = 0; i < so_luong_nv; i++)
            {
                tong = tong + dsnv.Ds_nv_new[i].Thuc_linh;
            }
            Console.WriteLine(tong);
        }
        public void In_nv_luong_thap_nhat()
        {
            if (so_luong_nv == 0) return;
            int minLuong = dsnv.Ds_nv_new[0].Luong_cb_Int;
            for (int i = 1; i < so_luong_nv; i++)
            {
                if (dsnv.Ds_nv_new[i].Luong_cb_Int < minLuong)
                {
                    minLuong = dsnv.Ds_nv_new[i].Luong_cb_Int;
                }
            }

            for (int i = 0; i < so_luong_nv; i++)
            {
                if (dsnv.Ds_nv_new[i].Luong_cb_Int == minLuong)
                {
                    dsnv.Ds_nv_new[i].Hien_thi();
                }
            }
        }
        public void Dem_thuong()
        {
            int dem = 0;
            for (int i = 0; i < so_luong_nv; i++)
            {
                if (dsnv.Ds_nv_new[i].Thuong_Int >= 1200000)
                {
                    dem = dem + 1;
                }
            }
            Console.WriteLine(dem);
        }
        public void Sap_xep_phong_ban()
        {
            if (so_luong_nv <= 1)
            {
                Hien_thi_ds();
                return;
            }

            Nhanvien[] temp = new Nhanvien[so_luong_nv];
            for (int i = 0; i < so_luong_nv; i++)
            {
                temp[i] = dsnv.Ds_nv_new[i];
            }

            for (int i = 0; i < so_luong_nv - 1; i++)
            {
                for (int j = i + 1; j < so_luong_nv; j++)
                {
                    int cmp = string.Compare(temp[i].Phong_ban, temp[j].Phong_ban, StringComparison.Ordinal);
                    if (cmp > 0 || (cmp == 0 && string.Compare(temp[i].MaNV, temp[j].MaNV, StringComparison.Ordinal) < 0))
                    {
                        Nhanvien t = temp[i];
                        temp[i] = temp[j];
                        temp[j] = t;
                    }
                }
            }

            for (int i = 0; i < so_luong_nv; i++)
            {
                temp[i].Hien_thi();
            }
        }
        public void Tang_luong()
        {
            for (int i = 0; i < so_luong_nv; i++)
            {
                int luongMoi = (int)(dsnv.Ds_nv_new[i].Luong_cb_Int * 1.05);
                dsnv.Ds_nv_new[i].Luong_cb_Int = luongMoi;
            }
        }
    }
}