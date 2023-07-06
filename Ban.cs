using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP1_BT2
{
    internal class Ban : DoDac
    {
        public override void InThongTin()
        {
            Console.WriteLine("Bàn có kích thước : " + TinhTheTich());
        }
    }
}
