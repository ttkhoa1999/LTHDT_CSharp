using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace bai1
{
    class Program
    {
        public class PhanSo
        {
            public int tu, mau;

            public PhanSo(int tuso, int mauso)
            {
                tu = tuso;
                mau = mauso;
            }

            public PhanSo(PhanSo ob)
            {
                tu = ob.tu;
                mau = ob.mau;
            }

            public void show()
            {
                Console.WriteLine("Phan so da cho : {0}/{1}",tu,mau);
            }
        }
        static void Main(string[] args)
        {
            PhanSo ob1 = new PhanSo(2, 5);
            ob1.show();
            PhanSo ob2 = new PhanSo(ob1);
            ob2.show();
            Console.ReadLine();
            return;
        }
    }
}
