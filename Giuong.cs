using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP1_BT2
{
    internal class Giuong : DoDac
    {
        public override void InThongTin()
        {
            Console.WriteLine("Giường có kích thước : " + TinhTheTich());
        }
    }
}
