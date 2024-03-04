using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class NhaPho : BatDongSan
    {
        public int namXayDung {get; private set;}
        public int soTang { get ; private set;}
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap nam xay dung: ");
            this.namXayDung = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so tang: ");
            this.soTang = int.Parse(Console.ReadLine());
            GlobalVariables.tongGiaNhaPho += this.giaBan;
            this.loai = 2;
        }
        public override void xuat()
        {
            Console.WriteLine("Loai: Nha Pho");
            base.xuat();
            Console.WriteLine("Nam xay dung: " + this.namXayDung);
            Console.WriteLine("So tang: " + this.soTang);
        }


    }
}
