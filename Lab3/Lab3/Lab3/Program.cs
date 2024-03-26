using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
    // bai 3.1
{

    public class HinhTron
    {
        private float BanKinh;

        public HinhTron()
        {
            BanKinh = 0.0f;
        }

        public HinhTron(float r)
        {
            BanKinh = r;
        }

        public void DatBanKinh(float r)
        {
            BanKinh = r;
        }

        public double LayChuVi()
        {
            return 2 * Math.PI * BanKinh;
        }

        public double LayDienTich()
        {
            return Math.PI * BanKinh * BanKinh;
        }

        public void ThongTin()
        {
            Console.WriteLine($"Hình tròn - Bán kính: {BanKinh}");
            Console.WriteLine($"Chu vi: {LayChuVi()}");
            Console.WriteLine($"Diện tích: {LayDienTich()}");
        }

        public static double operator +(HinhTron hinhTron1, HinhTron hinhTron2)
        {
            return hinhTron1.LayDienTich() + hinhTron2.LayDienTich();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Nhập vào 2 đối tượng hình tròn bằng hai phương thức khởi tạo khác nhau.
            HinhTron hinhTron1 = new HinhTron(5.0f); // Khởi tạo với bán kính 5.0
            HinhTron hinhTron2 = new HinhTron();
            Console.Write("Nhập bán kính cho hình tròn thứ hai: ");
            float banKinh = float.Parse(Console.ReadLine());
            hinhTron2.DatBanKinh(banKinh);

            // Xuất thông tin 2 đối tượng ra màn hình
            Console.WriteLine("Hình tròn 1:");
            hinhTron1.ThongTin();
            Console.WriteLine("\nHình tròn 2:");
            hinhTron2.ThongTin();

            // Cập nhật bán kính của đối tượng tạo ra bằng khởi tạo không tham số
            hinhTron2.DatBanKinh(8.0f);

            // Tính và in ra tổng diện tích của 2 hình tròn dùng toán tử cộng
            double tongDienTich = hinhTron1 + hinhTron2;
            Console.WriteLine($"\nTổng diện tích của hai hình tròn: {tongDienTich}");

            Console.Write("\nNhập số lượng hình tròn (2 < n < 30): ");
            int n = int.Parse(Console.ReadLine());

            if (n < 3 || n > 29)
            {
                Console.WriteLine("Số lượng hình tròn không hợp lệ. Thoát...");
                return;
            }

            List<HinhTron> danhSachHinhTron = new List<HinhTron>();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập bán kính cho hình tròn thứ {i + 1}: ");
                banKinh = float.Parse(Console.ReadLine());
                HinhTron hinhTron = new HinhTron(banKinh);
                danhSachHinhTron.Add(hinhTron);
            }

            // In ra thông tin n hình tròn vừa nhập
            Console.WriteLine("\nThông tin các hình tròn:");
            foreach (var hinhTron in danhSachHinhTron)
            {
                hinhTron.ThongTin();
                Console.WriteLine();
            }

            // Tính và in ra màn hình tổng chu vi của n hình tròn
            double tongChuVi = 0;
            foreach (var hinhTron in danhSachHinhTron)
            {
                tongChuVi += hinhTron.LayChuVi();
            }
            Console.WriteLine($"Tổng chu vi của {n} hình tròn là: {tongChuVi}");

            // Tìm và in ra thông tin hình tròn có diện tích lớn nhất
            double maxDienTich = double.MinValue;
            HinhTron hinhTronMaxDienTich = null;
            foreach (var hinhTron in danhSachHinhTron)
            {
                if (hinhTron.LayDienTich() > maxDienTich)
                {
                    maxDienTich = hinhTron.LayDienTich();
                    hinhTronMaxDienTich = hinhTron;
                }
            }
            Console.WriteLine($"Hình tròn có diện tích lớn nhất:");
            hinhTronMaxDienTich.ThongTin();
        }
    }
}


// bai 3.2 
public class HocPhan
{
    private string maHocPhan;
    private string tenHocPhan;
    private int soTinChi;
    private int soTinChiThucHanh;
    private const double hocPhi1TinChi = 350;

    public HocPhan()
    {
        soTinChi = 0;
        soTinChiThucHanh = 0;
    }

    public HocPhan(string ma, string ten, int tinChi, int tinChiThucHanh)
    {
        maHocPhan = ma;
        tenHocPhan = ten;
        soTinChi = tinChi;
        soTinChiThucHanh = tinChiThucHanh;
    }

    public void NhapThongTin()
    {
        Console.Write("Nhập mã học phần: ");
        maHocPhan = Console.ReadLine();
        Console.Write("Nhập tên học phần: ");
        tenHocPhan = Console.ReadLine();
        Console.Write("Nhập số tín chỉ: ");
        soTinChi = int.Parse(Console.ReadLine());
        Console.Write("Nhập số tín chỉ thực hành: ");
        soTinChiThucHanh = int.Parse(Console.ReadLine());
    }

    public double TinhTienHocPhi()
    {
        return soTinChiThucHanh * hocPhi1TinChi * 1.5 + (soTinChi - soTinChiThucHanh) * hocPhi1TinChi;
    }

    public void XuatThongTin()
    {
        Console.WriteLine($"Mã học phần: {maHocPhan}");
        Console.WriteLine($"Tên học phần: {tenHocPhan}");
        Console.WriteLine($"Số tín chỉ: {soTinChi}");
        Console.WriteLine($"Tiền học phí: {TinhTienHocPhi()}");
    }

    public static double operator +(int soTinChiThucHanh, HocPhan hocPhan)
    {
        return soTinChiThucHanh + hocPhan.soTinChiThucHanh;
    }
}

public class Circle
{
    private float radius;

    public Circle()
    {
        radius = 1;
    }

    public Circle(float r)
    {
        radius = r;
    }

    public void SetRadius(float r)
    {
        radius = r;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }

    public void Info()
    {
        Console.WriteLine($"Bán kính: {radius}");
        Console.WriteLine($"Chu vi: {GetPerimeter()}");
        Console.WriteLine($"Diện tích: {GetArea()}");
    }

    public static double operator +(Circle c1, Circle c2)
    {
        return c1.GetArea() + c2.GetArea();
    }

    public static double operator +(int soTinChiThucHanh, Circle circle)
    {
        return soTinChiThucHanh;
    }
}

    public class HoaDonHocPhi
    {
        private string maSinhVien;
        private string hoTen;
        private List<HocPhan> danhSachHocPhan;

    public HoaDonHocPhi()
    {
        danhSachHocPhan = new List<HocPhan>();
    }

    public HoaDonHocPhi(string ma, string ten)
    {
        maSinhVien = ma;
        hoTen = ten;
        danhSachHocPhan = new List<HocPhan>();
    }

    public void NhapThongTin()
    {
        Console.Write("Nhập mã số sinh viên: ");
        maSinhVien = Console.ReadLine();
        Console.Write("Nhập họ và tên: ");
        hoTen = Console.ReadLine();
        Console.Write("Nhập số lượng học phần đăng ký: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập thông tin học phần thứ {i + 1}:");
            HocPhan hocPhan = new HocPhan();
            hocPhan.NhapThongTin();
            danhSachHocPhan.Add(hocPhan);
        }
    }

    public int TongSoTinChiThucHanh()
    {
        int tong = 0;
        foreach (var hocPhan in danhSachHocPhan)
        {
            tong += hocPhan.TongSoTinChiThucHanh;
        }
        return tong;
    }
    public void XuatThongTin()
    {
        Console.WriteLine($"Mã số sinh viên: {maSinhVien}");
        Console.WriteLine($"Họ tên: {hoTen}");
        Console.WriteLine("Danh sách học phần:");
        foreach (var hocPhan in danhSachHocPhan)
        {
            hocPhan.XuatThongTin();
        }
        Console.WriteLine($"Tổng số tín chỉ thực hành: {TongSoTinChiThucHanh()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Nhập thông tin hóa đơn học phí
        HoaDonHocPhi hoaDon = new HoaDonHocPhi();
        hoaDon.NhapThongTin();

        // In ra thông tin hóa đơn vừa nhập
        Console.WriteLine("\nThông tin hóa đơn học phí:");
        hoaDon.XuatThongTin();

        // In ra tổng số tín chỉ thực hành
        Console.WriteLine($"\nTổng số tín chỉ thực hành: {hoaDon.TongSoTinChiThucHanh()}");
    }

}


// 3.3 
using System;
using System.Collections.Generic;

public class PhieuLuuTru
{
    private int soPhong;
    private string hoTenKhach;
    private DateTime ngayDen;
    private DateTime ngayDi;
    private int loaiPhong;
    private const double giaSan = 300;

    public PhieuLuuTru()
    {
        soPhong = 0;
        hoTenKhach = "";
        ngayDen = DateTime.Now;
        ngayDi = DateTime.Now;
        loaiPhong = 0;
    }

    public PhieuLuuTru(int soPhong, string hoTenKhach, DateTime ngayDen, DateTime ngayDi, int loaiPhong)
    {
        this.soPhong = soPhong;
        this.hoTenKhach = hoTenKhach;
        this.ngayDen = ngayDen;
        this.ngayDi = ngayDi;
        this.loaiPhong = loaiPhong;
    }

    public void NhapThongTin()
    {
        Console.Write("Nhập số phòng: ");
        soPhong = int.Parse(Console.ReadLine());
        Console.Write("Nhập họ tên khách: ");
        hoTenKhach = Console.ReadLine();
        Console.Write("Nhập ngày đến (yyyy/MM/dd): ");
        ngayDen = DateTime.Parse(Console.ReadLine());
        Console.Write("Nhập ngày đi (yyyy/MM/dd): ");
        ngayDi = DateTime.Parse(Console.ReadLine());
        Console.Write("Nhập loại phòng (1, 2, 3): ");
        loaiPhong = int.Parse(Console.ReadLine());
    }

    public double TinhTienPhong()
    {
        int soNgayO = (int)(ngayDi - ngayDen).TotalDays;
        double giaPhong;
        switch (loaiPhong)
        {
            case 1:
                giaPhong = 1.5 * giaSan;
                break;
            case 2:
                giaPhong = 1.3 * giaSan;
                break;
            default:
                giaPhong = giaSan;
                break;
        }
        return soNgayO * giaPhong;
    }

    public void XuatThongTin()
    {
        int soNgayO = (int)(ngayDi - ngayDen).TotalDays;
        double tienPhong = TinhTienPhong();
        Console.WriteLine($"Số phòng: {soPhong}");
        Console.WriteLine($"Họ tên khách: {hoTenKhach}");
        Console.WriteLine($"Số ngày ở: {soNgayO}");
        Console.WriteLine($"Giá phòng: {TinhGiaPhong():C}");
        Console.WriteLine($"Tiền phòng: {tienPhong:C}");
    }

    public static bool operator <(PhieuLuuTru phieu1, PhieuLuuTru phieu2)
    {
        int soNgayO1 = (int)(phieu1.ngayDi - phieu1.ngayDen).TotalDays;
        int soNgayO2 = (int)(phieu2.ngayDi - phieu2.ngayDen).TotalDays;
        return soNgayO1 < soNgayO2;
    }

    public static double operator +(double soTien, PhieuLuuTru phieu)
    {
        return soTien + phieu.TinhTienPhong();
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<PhieuLuuTru> danhSachPhieu = new List<PhieuLuuTru>();

        Console.Write("Nhập số lượng phiếu lưu trú (1 < n < 30): ");
        int n = int.Parse(Console.ReadLine());

        if (n < 2 || n > 29)
        {
            Console.WriteLine("Số lượng phiếu không hợp lệ.");
            return;
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập thông tin phiếu lưu trú thứ {i + 1}:");
            PhieuLuuTru phieu = new PhieuLuuTru();
            phieu.NhapThongTin();
            danhSachPhieu.Add(phieu);
        }

        // Sắp xếp danh sách phiếu theo thứ tự giảm dần của số ngày ở
        danhSachPhieu.Sort((p1, p2) => (p2 < p1) ? -1 : ((p1 < p2) ? 1 : 0));

        // Xuất thông tin phiếu lưu trú theo thứ tự giảm dần của số ngày ở
        Console.WriteLine("\nThông tin các phiếu lưu trú theo thứ tự giảm dần của số ngày ở:");
        foreach (var phieu in danhSachPhieu)
        {
            phieu.XuatThongTin();
            Console.WriteLine();
        }

        // Đếm và xuất ra màn hình số lượng phiếu lưu trú trong quý 1 năm 20
        int dem = 0;
        foreach (var phieu in danhSachPhieu)
        {
            if (phieu.NgayDen.Year == 2020 && phieu.NgayDen.Month >= 1 && phieu.NgayDen.Month <= 3)
            {
                dem++;
            }
        }
        Console.WriteLine($"\nSố lượng phiếu lưu trú trong quý 1 năm 2020: {dem}");
    }
}


