using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class ChungCu : BatDongSan
    {
        public int tang { get; private set; }

        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap tang: ");
            this.tang = int.Parse(Console.ReadLine());
            GlobalVariables.tongGiaChungCu += this.giaBan;
            this.loai = 3;
        }
        public override void xuat()
        {
            Console.WriteLine("Loai: Chung Cu");
            base.xuat();
            Console.WriteLine("Tang: " + this.tang);
        }
    }
}
