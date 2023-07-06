using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP1_BT2
{
    internal class CongTyChuyenDo
    {
        private string tenCongTy;
        public CongTyChuyenDo()
        {
            
        }

        public CongTyChuyenDo(string tenCongTy)
        {
            this.tenCongTy = tenCongTy;
        }

        public string TenCongTy { get => tenCongTy; set => tenCongTy = value; }


        // Array list này để chứa danh sách khách hàng 

        ArrayList _lstKh = new ArrayList();

        KhachHang kh;

        public void NhapThongTinKh()
        {
            string tiepTuc;
            do
            {
                kh = new KhachHang();
                Console.WriteLine("Nhập tên : ");
                kh.Ten = Console.ReadLine();
                Console.WriteLine("Nhập tuổi : ");
                kh.Tuoi = Console.ReadLine();
                Console.WriteLine("Nhập số điện thoại: ");
                kh.Sdt = Console.ReadLine();
                Console.WriteLine("Nhập địa chỉ: ");
                kh.DiaChi = Console.ReadLine();
                kh.AddDo();
                Console.WriteLine("Bạn có muốn tiếp tục không(y/n) ? ");
                tiepTuc = Console.ReadLine();
                _lstKh.Add(kh);

            } while (tiepTuc.Equals("y"));
        }

        // Phương thức này trả về all các khách hàng để hàm main sử dụng 

        public ArrayList LayKhachHang()
        {
            ArrayList lstKhs = new ArrayList();
            foreach (var item in _lstKh)
            {
                lstKhs.Add(item);

            }
            return lstKhs;
        }

    

       
        // Phương thức này để thêm khách hàng vào trong danh sách khách hàng 
        public void AddKHVaoDanhSachKh()
        {
            Console.WriteLine("Nhập thông tin khách hàng bạn muốn thêm: ");
            string tiepTuc;
            do
            {
                kh = new KhachHang();
                Console.WriteLine("Nhập tên : ");
                kh.Ten = Console.ReadLine();
                Console.WriteLine("Nhập tuổi : ");
                kh. Tuoi = Console.ReadLine();
                Console.WriteLine("Nhập số điện thoại: ");
                kh.Sdt = Console.ReadLine();
                Console.WriteLine("Nhập địa chỉ: ");
                kh.DiaChi = Console.ReadLine();
                kh.AddDo();
                _lstKh.Add(kh);
                do
                {
                    Console.WriteLine("Bạn có muốn tiếp tục không(y/n) ? ");
                    tiepTuc = Console.ReadLine();


                } while (tiepTuc.Equals("y"));
        } while (tiepTuc.Equals("y"));
        }
        // phương thức này để Xóa Khách hàng khỏi danh sách khách hàng

        public void XoaKhachHang()
        {
            Console.WriteLine("Danh sách khách hàng");
            foreach (KhachHang item in _lstKh)
            {
                item.InThongTin();
            }
            Console.WriteLine("Nhập vị trí khách hàng muốn xóa: ");
            int vitri = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < _lstKh.Count; i++)
            {
                if (i == vitri-1)
                {

                    _lstKh.RemoveAt(i);
                    Console.WriteLine("Đã xóa thành công ");
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy ");
        }

    }
}
