using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP1_BT2
{
    internal class TuDo : DoDac
    {
        public override void InThongTin()
        {
            Console.WriteLine("Tủ đồ có kích thước : " + TinhTheTich());
        }
    }
}
