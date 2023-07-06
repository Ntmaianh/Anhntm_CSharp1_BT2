using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP1_BT2
{
    internal abstract class DoDac
    {
        private double chieuRong;
        private double chieuSau;
        private double chieuCao;
        private double theTich;

        public double TheTich { get => theTich; set => theTich = value; }
        public double ChieuRong { get => chieuRong; set => chieuRong = value; }
        public double ChieuSau { get => chieuSau; set => chieuSau = value; }
        public double ChieuCao { get => chieuCao; set => chieuCao = value; }

        public DoDac()
        {

        }

        protected DoDac(double chieuRong, double chieuSau, double chieuCao, double theTich)
        {
            this.chieuRong = chieuRong;
            this.chieuSau = chieuSau;
            this.chieuCao = chieuCao;
            this.theTich = theTich;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhập thông tin");
            Console.WriteLine("Nhập chiều rộng: ");
            chieuRong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập chiều cao: ");
            chieuCao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập chiều sâu: ");
            chieuSau = Convert.ToInt32(Console.ReadLine());

        }
        public double TinhTheTich()
        {
            theTich = chieuSau * chieuRong * chieuCao;
            return theTich;
        }

        public abstract void InThongTin();
    }
}