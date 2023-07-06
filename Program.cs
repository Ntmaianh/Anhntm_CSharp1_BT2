using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP1_BT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            CongTyChuyenDo cty = new CongTyChuyenDo();
            // thông tin của công ti 
            Console.WriteLine("Nhập tên công ty chuyền đồ: ");
            cty.TenCongTy = Console.ReadLine();
            const int theTichChoPhep = 10;

            // danh sách này dùng để lưu các khách hàng tạo sẵn
            ArrayList lstDaTaKH = new ArrayList();

            Console.WriteLine("Nhập thông tin khách hàng ");
            cty.NhapThongTinKh();
            foreach (var item in cty.LayKhachHang())
            {
                lstDaTaKH.Add(item);
            }

            // từ dòng 29 - 40 là để check xem danh sách data khách hàng có trống không 
            // nếu không trống thì in ra thông tin và check luôn vận chuyển
            if (lstDaTaKH.Count == 0)
            {
                Console.WriteLine("Danh Sach trống");
            }
            else
            {
                foreach (KhachHang item in lstDaTaKH)
                {
                    double tongVanChuyen = item.TongTheTich();

                    item.InThongTin();


                    if (tongVanChuyen <= theTichChoPhep)
                    {
                        Console.WriteLine("Đủ tiêu chuẩn vận chuyển");
                    }
                    else
                    {
                        Console.WriteLine("Không đủ tiêu chuẩn vận chuyển");
                    }
                }

            }

            Menu();


        }

        static void Menu()
        {
            int choose;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Chức năng của khách hàng");
                Console.WriteLine("2.Chức năng của công ty ");
                Console.WriteLine("0.Thoát");
                Console.WriteLine("Mời bạn lựa chọn: ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        MenuKH();
                        break;
                    case 2:
                        MenuCty();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ! Chọn lại ");
                        break;
                }
            } while (choose != 0);

        }
        static void MenuKH()
        {
            int choose;
            KhachHang kh = new KhachHang();
            do
            {
                Console.WriteLine("Chức năng chính");
                Console.WriteLine("1.Thêm đồ đạc ");
                Console.WriteLine("2. Xóa đồ đạc đã thêm   ");
                Console.WriteLine("0.Thoát ");
                Console.WriteLine("Mời bạn lựa chọn: ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        kh.AddDo();
                        break;
                    case 2:
                        kh.XoaDoDac();
                        break;
                    case 0:
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ! Chọn lại ");
                        break;
                }
            } while (choose != 0);

        }

        static void MenuCty()
        {
            int choose;
            CongTyChuyenDo cty = new CongTyChuyenDo();
            do
            {
                Console.WriteLine("Chức năng chính");
                Console.WriteLine("1.Thêm Khách hàng ");
                Console.WriteLine("2. Xóa khách hàng đã thêm ");
                Console.WriteLine("0.Thoát ");
                Console.WriteLine("Mời bạn lựa chọn: ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                    cty.AddKHVaoDanhSachKh();
                    break;
                case 2:
                    cty.XoaKhachHang();
                    break;
                case 0:
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ! Chọn lại ");
                    break;
                }
            } while (choose != 0);

        }
    }
}
