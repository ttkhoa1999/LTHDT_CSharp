using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    class Program
    {
       class PhanSo{
            public int tu;
            public int mau;
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
                Console.WriteLine("Phan so da cho la :{0}/{1} ",tu , mau);
            }
        }
        static void Main(string[] args)
        {
            PhanSo k1 = new PhanSo();
            k1.show();
            PhanSo k2 = new PhanSo(7);
            k2.show();
            PhanSo k3 = new PhanSo(6, 9);
            k3.show();
            Console.ReadLine();
            return;
        }
    }
}
