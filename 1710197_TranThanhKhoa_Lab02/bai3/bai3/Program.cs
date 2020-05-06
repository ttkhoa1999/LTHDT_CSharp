using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class Program
    {
        public class TienIch
        {
            public static long LuyThua(int coso, int somu)
            {
                long ketqua = 1;
                for (int i = 0; i < somu; i++)
                {
                    ketqua *= coso;
                }
                return ketqua;
            }
            public static int USCLN(int a, int b)
            {
                a = Math.Abs(a);
                b = Math.Abs(b);
                while (a != b)
                {
                    if (a > b)
                        a = a - b;
                    if (a < b)
                        b = b - a;
                }
                return a;
            }
            public static int BSCNN(int a, int b)
            {

                int kq = 1;
                int max = a * b;
                for (int i = Math.Max(a, b); i <= max; i++)
                {
                    if (i % a == 0 && i % b == 0)
                    {
                        kq = i;
                        break;
                    }
                    else
                        kq = max;
                }
                return kq;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Luy Thua : "+TienIch.LuyThua(3, 3));
            Console.WriteLine("USCLN : "+TienIch.USCLN(5, 3));
            Console.WriteLine("BSCNN : "+TienIch.BSCNN(5, 7));
            Console.ReadLine();
        }
    }
}
