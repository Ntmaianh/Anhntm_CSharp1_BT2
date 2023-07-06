using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSHARP1_BT2
{
    internal class KhachHang
    {
        private string ten;
        private string tuoi;
        private string sdt;
        private string diaChi;

        public KhachHang()
        {

        }

        public KhachHang(string ten, string tuoi, string sdt, string diaChi)
        {
            this.ten = ten;
            this.tuoi = tuoi;
            this.sdt = sdt;
            this.diaChi = diaChi;
        }

        public string Sdt { get => sdt;

            set 
            { 
                 if(!Regex.IsMatch(value,@"^[0]{1}[0-9]{9}$"))
                {
                    Console.WriteLine("Nhập không hợp lệ!");
                    sdt = Console.ReadLine();
                }
                 else
                {
                    sdt = value;
                }
            
            } }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Tuoi { get => tuoi;
            set 
            {
                if (!Regex.IsMatch(value.ToString(), @"^[0-9]*$"))
                {
                    Console.WriteLine("Nhập không hợp lệ");
                    tuoi = Console.ReadLine();
                }
                else
                {
                    tuoi = value;
                }
            } }

        // đây là danh sách đồ đạc mà khách hàng quản lí 


        ArrayList lstDoDac = new ArrayList();


        // khai báo ra từng đối tượng của từng lớp kế thừa từ lớp đồ dạc 
        MayTinh mt;

        Ban ban;

        Ghe ghe;

        Giuong giuong;

        TuDo tuDo;

        // phương thức này để thêm đồ 
        public void AddDo()
        {
           
                int choose;
                do
                {
                    Console.WriteLine("Chọn đồ dùng bạn muốn thêm ");
                    Console.WriteLine("1.Bàn");
                    Console.WriteLine("2Máy tính");
                    Console.WriteLine("3.Ghế");
                    Console.WriteLine("4.Giường");
                    Console.WriteLine("5.Tủ đồ ");
                    Console.WriteLine("0.Nhấn 0 để thoát khỏi khi không muốn thêm");
                    Console.WriteLine("Mời bạn lựa chọn: ");
                    choose = Convert.ToInt32(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:

                            mt = new MayTinh();
                            mt.Nhap();
                            lstDoDac.Add(mt);
                            break;
                        case 2:
                            ban = new Ban();
                            ban.Nhap();
                            lstDoDac.Add(ban);
                            break;
                        case 3:
                            ghe = new Ghe();
                            ghe.Nhap();
                            lstDoDac.Add(ghe);
                            break;
                        case 4:
                            giuong = new Giuong();
                            giuong.Nhap();
                            lstDoDac.Add(giuong);
                            break;
                        case 5:
                            tuDo = new TuDo();
                            tuDo.Nhap();
                            lstDoDac.Add(tuDo);
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine("Nhập không hợp lệ");
                            Console.WriteLine("Nhập lại ");
                            break;
                    }
                  
                } while (choose != 0);

            
        }


        // phương thức này để xóa đồ đạc 
        public void XoaDoDac()
        {
            Console.WriteLine("Danh sách đồ dùng");
            foreach (DoDac item in lstDoDac)
            {
                item.InThongTin();
            }
            Console.WriteLine("Mời nhập đồ đạc ở vị trí muốn xóa: ");
            int vitri = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < lstDoDac.Count; i++)
            {
                if (i == vitri - 1 )
                {

                    lstDoDac.RemoveAt(i);
                    Console.WriteLine("Đã xóa thành công ");
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy ");
        }
        
       
        
       // Đây là phương thức inThongTin Khách hàng 
        public void InThongTin()
        {
            Console.WriteLine($"Thông tin khách hàng: {ten}|{tuoi}|{sdt}|{diaChi} ");
            foreach (DoDac item in lstDoDac)
            {
                item.InThongTin();
            }
            CongTyChuyenDo cty = new CongTyChuyenDo();
        }
        // Đây là phương thức tính tổng thể tích 

        public double TongTheTich()
        {
            double sum = 0;
            foreach (DoDac item in lstDoDac)
            {
                sum += item.TinhTheTich();
            }
            return sum;
        }


    }
}
