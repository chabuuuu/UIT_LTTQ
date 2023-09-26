using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToanTuChuyenDoi_CacViDu;

namespace ToanTuChuyenDoi_CacViDu
{
        public class Phanso
    {
    public Phanso(int ts, int ms)
    {
    this.ts = ts;
    this.ms = ms;
    }
    public Phanso(int wholeNumber)
    {
    ts = wholeNumber;
    ms = 1;
    }
    public static implicit operator Phanso(int theInt)
    {
        return new Phanso(theInt);
        }
    public static explicit operator int(Phanso thePhanso)
    {
        return thePhanso.ts / thePhanso.ms;
        }
    public static bool operator ==(Phanso lhs, Phanso rhs)
    {
        if (lhs.ts == rhs.ts && lhs.ms == rhs.ms)
            {
            return true;
            }
        return false;
        }
    public static bool operator !=(Phanso lhs, Phanso rhs)
    {
        return !(lhs == rhs);
        }
    public override bool Equals(object o)
    {
        if (!(o is Phanso))
            {
            return false;
            }
        return this == (Phanso)o;
        }
    public static Phanso operator +(Phanso lhs, Phanso
    rhs)
    {
        if (lhs.ms == rhs.ms)
            {
            return new Phanso(lhs.ts + rhs.ts, lhs.ms);
            }
        int firstProduct = lhs.ts * rhs.ms;
        int secondProduct = rhs.ts * lhs.ms;
        return new Phanso(firstProduct + secondProduct,
        lhs.ms * rhs.ms);
        }
    public override string ToString()
    {
        string s = ts.ToString() + "/" + ms.ToString();
        return s;
        }
    private int ts;
    private int ms;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Phanso f1 = new Phanso(3, 4);
            Console.WriteLine("f1:{0}", f1.ToString());
            Phanso f2 = new Phanso(2, 4);
            Console.WriteLine("f2:{0}", f2.ToString());
            Phanso f3 = f1 + f2;
            Console.WriteLine("f1 + f2 = f3:{0}", f3.ToString());
            Phanso f4 = f3 + 5;
            Console.WriteLine("f4 = f3 + 5:{0}", f4.ToString());
            Phanso f6 = 5 + f3;
            Console.WriteLine("f6 = 5 + f3:{0}", f6.ToString());
            Phanso f5 = new Phanso(2, 4);
            if (f5 == f2)
                {
                 Console.WriteLine("f5:{0}==f2:{1}", f5.ToString(),
                f2.ToString());
                }
            Console.ReadLine();
        }
    }
}
