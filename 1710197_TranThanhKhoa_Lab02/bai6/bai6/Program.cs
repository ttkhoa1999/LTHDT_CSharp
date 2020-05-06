using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    class Program
    {
        public class PhanSo
        {
            int tu;
            int mau;
            public PhanSo()
            {
                tu = 0;
                mau = 1;
            }

            public PhanSo(int x)
            {
                tu = x;
                mau = 1;
            }
 
            public PhanSo(int x, int y)
            {
                tu = x;
                mau = y;
            }
            public void show()
            {
                Console.WriteLine("Phan so: {0}/{1}", tu, mau);
            }

            public PhanSo Cong(PhanSo PS2)
            {
                int TS = tu * PS2.mau + mau * PS2.tu;
                int MS = mau * PS2.mau;

                PhanSo kq = new PhanSo(TS, MS);
                return kq;
            }

            public PhanSo Tru(PhanSo PS2)
            {
                int TS = tu * PS2.mau - mau * PS2.tu;
                int MS = mau * PS2.mau;

                PhanSo kq = new PhanSo(TS, MS);
                return kq;
            }

            public PhanSo Nhan(PhanSo PS2)
            {
                int TS = tu * PS2.tu;
                int MS = mau * PS2.mau;

                PhanSo kq = new PhanSo(TS, MS);
                return kq;
            }
            public PhanSo Chia(PhanSo PS2)
            {
                int TS = tu * PS2.mau;
                int MS = mau * PS2.tu;

                PhanSo kq = new PhanSo(TS, MS);
                return kq;
            }

            public bool SoSanhBang(PhanSo ps)
            {
                return tu * ps.mau == mau * ps.tu;
            }

        }
        static void Main(string[] args)
        {
            PhanSo p1 = new PhanSo();
            p1.show();
            Console.WriteLine();
            PhanSo p2 = new PhanSo(3);
            p2.show();
            Console.WriteLine();
            Console.WriteLine("Nhap tu so: ");
            int TS = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so: ");
            int MS = int.Parse(Console.ReadLine());
            PhanSo p3 = new PhanSo(TS, MS);
            p3.show();
            Console.WriteLine();
            p1 = p2.Cong(p3);
            p1.show();
            p1 = p2.Tru(p3);
            p1.show();
            p1 = p2.Nhan(p3);
            p1.show();
            p1 = p2.Chia(p3);
            p1.show();
            Console.ReadLine();
        }
    }
}
