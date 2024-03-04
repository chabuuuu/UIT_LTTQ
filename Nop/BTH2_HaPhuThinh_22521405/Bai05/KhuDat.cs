using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class KhuDat : BatDongSan
    {
        public override void nhap()
        {    base.nhap();
            GlobalVariables.tongGiaKhuDat += this.giaBan;
            this.loai = 1;
        }
        public override void xuat()
        {
            Console.WriteLine("Loai: Khu Dat");
            base.xuat();
        }
    }
}
