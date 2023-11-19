using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class Program
    {
        public static int test = 0;

        static bool check(dynamic batdongsan)
        {
            if (batdongsan.loai == 1) { 
                    if (batdongsan.dienTich > 100)
                    {
                        return true;
                    }
                return false;
            }
            if (batdongsan.loai == 2)
            {
                if (batdongsan.dienTich > 60 && batdongsan.namXayDung >= 2019)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        static bool search(BatDongSan batDongSan, string diaDiemSearch, float giaBanSearch, float dienTichSearch)
        {
            bool stringEqual = string.Equals(batDongSan.diaDiem, diaDiemSearch, StringComparison.OrdinalIgnoreCase);
            if (stringEqual == false)
            {
                return false;
            }
            if (batDongSan.giaBan > giaBanSearch)
            {
                return false;
            }
            if (batDongSan.dienTich < dienTichSearch)
            {
                return false;
            }
            return true;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong bat dong san: ");
            int ammount = int.Parse(Console.ReadLine());
            BatDongSan[] listBatDongSan = new BatDongSan[ammount];
            for (int i = 0; i < ammount; i++)
            {
                Console.WriteLine("Chon loai bat dong san: 1. Khu dat, 2. Nha pho, 3. Chung cu");
                int type = int.Parse(Console.ReadLine());
                switch(type)
                {
                    case 1:
                        listBatDongSan[i] = new KhuDat();
                        break;
                    case 2:
                        listBatDongSan[i] = new NhaPho();
                        break;
                    case 3:
                        listBatDongSan[i] = new ChungCu();
                        break;
                    default:
                        break;
                }
                listBatDongSan[i].nhap();
            }

            Console.WriteLine("Thong tin cac bat dong san: \n");
            for (int i = 0; i < ammount; i++)
            {
                listBatDongSan[i].xuat();
            }
            Console.WriteLine("Tong gia ban tung loai bat dong san: \n");
            Console.WriteLine("Chung Cu: " + GlobalVariables.tongGiaChungCu);
            Console.WriteLine("Khu Dat: " + GlobalVariables.tongGiaKhuDat);
            Console.WriteLine("Nha Pho: " + GlobalVariables.tongGiaNhaPho);

            Console.WriteLine("Danh sach cac bat dong san thoa dieu kien: \n");
            for (int i = 0; i < ammount; i++)
            {
                if (check(listBatDongSan[i]))
                {
                    listBatDongSan[i].xuat();
                }
            }

            Console.WriteLine("Nhap thong tin can tim kiem: \n");
            Console.WriteLine("Nhap dia diem: \n");
            string diaDiemSearch = Console.ReadLine();
            Console.WriteLine("Nhap gia ban: \n");
            float giaBanSearch = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap dien tich: \n");
            float dienTichSearch = float.Parse(Console.ReadLine());

            Console.WriteLine("Ket qua tim kiem: \n");

            for (int i = 0; i < ammount; i++)
            {
                if (search(listBatDongSan[i], diaDiemSearch, giaBanSearch, dienTichSearch))
                {
                    listBatDongSan[i].xuat();
                }
            }

            Console.ReadKey();
        }
    }
}
