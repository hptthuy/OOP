using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1

{
    internal class Program
    {
        /* Bài 1.1 Nhập 3 giá trị tương ứng với họ tên, ngày sinh, giới tính của một sinh viên. 
        Xuất ra màn hình các giá trị vừa nhập trên 1 dòng. */
        static void Baitap1_1()
        {
            // khai báo( sử dụng kiểu chuỗi )
            string hoten; // kiểu chuỗi 

            DateTime ngaysinh;

            bool gioitinh; // bool dùng cho giới tính 

            //nhap gia tri 
            Console.Write("Nhập họ tên của bạn: ");
            hoten = Console.ReadLine();

            Console.Write("Nhập ngày sinh của bạn: ");
            ngaysinh = Convert.ToDateTime(Console.ReadLine()); // dùng Convert.ToDateTime để đổi kiểu 

            Console.Write("Nhập giới tính của bạn ( True: nữ / False: nam ): ");
            gioitinh = bool.Parse(Console.ReadLine()); // giới tính thì dùng bool.Parse 

            // xuất màn hình 
            if (gioitinh)
                Console.Write($"{hoten}\t{ngaysinh.ToShortDateString()}tnam");
            else
                Console.Write($"{hoten}\t{ngaysinh.ToShortDateString()}\tnu");
        }








        /* Bài 1.2 Nhập vào 2 giá trị tương ứng với họ tên và ngày sinh của một người. Xuất ra màn 
hình họ tên và tuổi của người vừa nhập trên 1 dòng. */

        static void BT1_2()
        {
            // khai bao 
            string hoten;
            DateTime ngaysinh;
            // nhap du lieu sinh vien tu viet 
            Console.Write("\n Bài tập 1/2 : ");
            Console.Write("\n Nhập họ và tên: ");
            hoten= Console.ReadLine();
            Console.Write("Nhập ngày sinh : ");
            ngaysinh= Convert.ToDateTime(Console.ReadLine());
            // tinh tuoi = nam hien tai - nam sinh 
            int tuoi=DateTime.Today.Year - ngaysinh.Year; // lay duoc nam hien tai trong he thong 
            // xuat ra man hinh 
            Console.Write(" \n Vậy họ tên và tuổi của bạn là :" + ngaysinh  + tuoi);

        }







        static void BT1_3()
        /* Bài 1.3. Nhập vào một năm, kiểm tra năm nhập vào có phải là năm nhuận không 
           Muốn kiểm tra năm đó có nhuận hay không, thì áp dụng công thức: số năm đó chia hết cho 4 và không chia hết cho 100 ( hoặc chia hết cho 400 ) 
           Case test : - năm nhuận gồm những năm : 2004, 2008. 201. 2016, 2020. 2024
                       - năm không nhuận : bao gồm các năm xen kẽ trong các năm trên    */ 
        {
            int nam;
            Console.WriteLine(" \n Bài tập 1/3: ");
            Console.WriteLine(" \n Nhập vào một năm bất kì: ");
            nam = int.Parse(Console.ReadLine());
            if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
            {
                Console.WriteLine("Vậy {0} là năm nhuận ", nam);
            }
            else
                Console.WriteLine("Vậy {0} không phải là năm nhuận ", nam);
        }






        static void BT1_4()
             /*Bài 1.4. Viết chương trình nhập vào 2 số nguyên a, b và một ký tự c; biết rằng c là một trong 
                4 ký tự '+', '-', '*', '/'. Tính và hiển thị kết quả của biểu thức khi áp dụng phép toán c trên 2 số
                nguyên a và b.
                Ví dụ: Nhập a = 7, c = '+', b = 9, kết quả trên màn hình:
                7 + 9 = 16 */ 
        {
            int a, b;
            char c;

            Console.Write(" \n Bài tập 1/4: ");
            Console.Write(" -  Nhập số nguyên a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write(" - Nhập số nguyên b: ");
            b = int.Parse(Console.ReadLine());

            Console.Write(" - Nhập ký tự phép toán (+, -, *, /): ");
            c = char.Parse(Console.ReadLine());

            int ketQua = 0;

            switch (c)
            {
                // casse '+' : Console.write($"{a} {c} {b} = {a +b}"); break;
                // casse '-' : Console.write($"{a} {c} {b} = {a +b}"); break;
                // casse '*' : Console.write($"{a} {c} {b} = {a +b}"); break;
                // casse '/' : Console.write($"{a} {c} {b} = {a +b}"); break;

                case '+':
                    ketQua = a + b;
                    break;
                case '-':
                    ketQua = a - b;
                    break;
                case '*':
                    ketQua = a * b;
                    break;
                case '/':
                    ketQua = a / b;
                    break;
                default:
                    Console.WriteLine("\t Phép toán k hợp lệ");
                    return;
            }

            Console.WriteLine("\n {0} {1} {2} = {3}", a, c, b, ketQua);
    }
        static  void BT1_5()
        {
            Console.WriteLine("\n Bài tập 1/5: ");
            Console.WriteLine("\n Chương trình có các lựa chọn để tính diện tích như sau: ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("1. tinh dien tich hinh tron");
            Console.WriteLine("2. tinh dien tich hinh chu nhat ");
            Console.WriteLine("3. tinh dien tich hinh tam giac");
          
            Console.Write("\t Nhập lựa chọn của bạn(1|2|3) : ");
            byte chon=Convert.ToByte(Console.ReadLine());
            float? dientich=null;
            switch (chon)
            {
                case 1: 
                    Console.Write(" nhap vao ban kinh hinh tron");
                    float r=Convert.ToSingle(Console.ReadLine());
                    dientich = (float)Math.PI * r * r;
                    break;
                case 2:
                    Console.Write(" Nhập chiều dài hình chữ nhật: ");
                    double length = double.Parse(Console.ReadLine());
                    Console.Write("Nhập chiều rộng hình chữ nhật: ");
                    double width = double.Parse(Console.ReadLine());
                  
                    break;

            }
            Console.Write($"\t Diện tích là : {dientich}");
        }





        static void BT1_6()
          /*  Viết chương trình kiểm tra mật khẩu người dùng nhập vào có hợp lệ hay không? Biết rằng mật khẩu hợp lệ là 123. Mỗi lần người dùng nhập sai, 
          chương trình sẽ thông báo “Mậtkhẩu không hợp lệ!” và cho phép người dùng nhập lại.Nếu nhập đúng mật khẩu, chương trình sẽ thông báo “Đăng nhập thành công!”. 
          Chương trình sẽ kết thúc nếu người dùng nhập đúng mật khẩu hoặc số lần nhập sai quá 3. */
          /* gợi ý làm bài:  khai báo biến là SoLanNhapSai=0 
           nếu số lần nhập sai < 3 thì mở lệnh if, nếu nhập đúng mật khẩu là 123 thì cho dừng lệnh, else thì trả lời : mật khẩu không hợp lệ 
           nếu số lần nhập mật khẩu trên 3 lần thì in ra : đã quá số lần nhập mật khẩu */

            {
            int solannhapsai =0;
            while (solannhapsai <3)
            {
                Console.Write("\n moi nhap mat khau: ");
                string matkhau =Console.ReadLine();
                if (matkhau == "123")
                {
                    Console.WriteLine("dung mat khau");
                    break;
                }
                else
                {
                    Console.WriteLine("Mat khau khong hop le");
                    solannhapsai++;
                }
                if(solannhapsai >=3)
                    Console.WriteLine("da qua so lan nhap mat khau ");
            }
            }








        static void BT1_7()
        /*  Bài 1.7. Viết chương trình thực hiện các yêu cầu sau:
              - Nhập vào một mảng số nguyên gồm n phần tử, n thuộc [3, 20]
              - In ra màn hình các số trong mảng theo thứ tự tăng dần(dùng hàm hoán đổi vị trí 2 phần
              tử khi sắp xếp thứ tự).
              - Đếm và in ra số phần tử là số nguyên tố trong mảng(dùng hàm kiểm tra 1 số có là
              nguyên tố hay không? */
        /* gợi ý làm bài : 
          1. câu lệnh để cho nhập từ 3 - 20 ( 1 số trong khung số này ) 
          2. nếu n <3 || > 20 thì in ra dòng "phần tử không hợp lệ 
          3. */
        {
            Console.WriteLine("\n nhập số phần tử của mảng ( 3 - 20): ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 3 || n > 20)
            {
                Console.WriteLine("phần tử này không hợp lệ ");
                return;
            }
            int[] mang = new int[n];
            // Nhập giá trị cho mảng
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                mang[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Sắp xếp mảng theo thứ tự tăng dần
            SapXepTangDan(mang);

            // In ra mảng đã sắp xếp
            Console.WriteLine("Các số trong mảng theo thứ tự tăng dần:");
            InMang(mang);

            // Đếm và in ra số phần tử là số nguyên tố trong mảng
            int soLuongSoNguyenTo = DemSoNguyenTo(mang);
            Console.WriteLine($"Số phần tử là số nguyên tố trong mảng: {soLuongSoNguyenTo}");
        }
            public static void SapXepTangDan(int[] mang)
            {
                int n = mang.Length;

                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (mang[j] < mang[i])
                        {
                            int temp = mang[i];
                            mang[i] = mang[j];
                            mang[j] = temp;
                        }
                    }
                }
            }
             public static void InMang(int[] mang)
            {
                foreach (int phanTu in mang)
                {
                    Console.Write(phanTu + " ");
                }
                Console.WriteLine();
            }

            public static bool KiemTraNguyenTo(int so)
            {
                if (so < 2)
                {
                    return false;
                }
                for (int i = 2; i <= Math.Sqrt(so); i++)
                {
                    if (so % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            public static int DemSoNguyenTo(int[] mang)
            {
                int dem = 0;

                foreach (int phanTu in mang)
                {
                    if (KiemTraNguyenTo(phanTu))
                    {
                        dem++;
                    }
                }

                return dem;
            }



        // static void BT1_8()
        //a 
            // kq :  15, 10 
            // giải thích : vì in ra {1} truoc, {0} sau
        // b 
            // kq: 1, 0 , cung giong nhu cau a, tuy nhien trong cau lenh co su dung % nhu mot phep hoan doi
        // c
            // ko hop le,  vì sử dụng biến a ( khai báo int a, thì ko thể sử dụng string
        // d
            //vì chk chưa được khai báo nên khi sử dụng trong if() là ko đúng 
        // e
            // 1

        static void Main(string[] args) // static : phương thức tĩnh
       
        {
            Console.OutputEncoding = Encoding.Unicode;
            Baitap1_1();
            BT1_2();
            BT1_3();
            BT1_4();
            BT1_5();
            BT1_6();
            BT1_7();
            Console.ReadKey();
        }
    }
}
