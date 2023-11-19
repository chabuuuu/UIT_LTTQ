using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class BatDongSan
    {
        public string diaDiem { get; protected set; }
        public float giaBan { get; protected set; }
        public float dienTich { get; protected set; }
        public int loai { get; protected set; }



        public virtual void nhap()
        {
            Console.WriteLine("Nhap dia diem: ");
            this.diaDiem = Console.ReadLine();
            Console.WriteLine("Nhap gia ban: ");
            this.giaBan = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap dien tich: ");
            this.dienTich = float.Parse(Console.ReadLine());
        }

        public virtual void xuat()
        {
            Console.WriteLine("Dia diem: " + this.diaDiem);
            Console.WriteLine("Gia ban: " + this.giaBan);
            Console.WriteLine("Dien tich: " + this.dienTich);
        }
    }
}
