using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace bai7
{
    class Program
    {
        public class PhanSo
        {
            int tu, mau;
            bool dau;
            public PhanSo()
            {
         
                dau = true;
            }

            public PhanSo(int tuso, int mauso)
            {
                tu = tuso;
                mau = mauso;
            }
            public void Nhap()
            {
                Console.WriteLine("Nhap tu so: ");
                tu = int.Parse(Console.ReadLine());
                while(mau == 0)
                {
                    Console.WriteLine("Nhap mau so: ");
                    mau = int.Parse(Console.ReadLine());
                }
            }
            public void Xuat()
            {
                Console.WriteLine("Phan so vua nhap: {0}/{1}",tu,mau);
            }
            public static PhanSo operator +(PhanSo a, PhanSo b)
            {
                int tuMoi = a.tu * b.mau + a.mau * b.tu;
                int mauMoi= a.mau * b.mau;
                PhanSo c = new PhanSo(tuMoi, mauMoi);
                return c;
            }
            public static PhanSo operator -(PhanSo a, PhanSo b)
            {
                int tuMoi = a.tu * b.mau - a.mau * b.tu;
                int mauMoi = a.mau * b.mau;
                PhanSo c = new PhanSo(tuMoi,mauMoi);
                return c;
            }
            public static PhanSo operator *(PhanSo a, PhanSo b)
            {
                int tuMoi = a.tu * b.tu;
                int mauMoi = a.mau * b.mau;
                PhanSo c = new PhanSo(tuMoi,mauMoi);
                return c;
            }
            public static PhanSo operator /(PhanSo a, PhanSo b)
            { 
                int tuMoi = a.tu * b.mau;
                int mauMoi = a.mau * b.tu;
                PhanSo c = new PhanSo(tuMoi,mauMoi);
                return c;
            }
            public static bool operator ==(PhanSo a, PhanSo b)
            {
                return (a.tu*b.mau == a.mau * b.tu);
            }
            public static bool operator !=(PhanSo a, PhanSo b)
            {
                return !(a == b);
            }

            public override bool Equals(object obj)
            {
                Console.WriteLine("Phuong thuc Equals");
                if (!(obj is PhanSo))
                    return false;
                return this == (PhanSo) obj;
            }
            public static PhanSo operator ++(PhanSo a)
            {
                a.tu = a.mau + a.tu;
                return a;
            }
            public override string ToString()
            {
                String s = tu.ToString() + "/" + mau.ToString();
                return s;
            }
        }
        static void Main(string[] args)
        {
            PhanSo a = new PhanSo();
            a.Nhap();
            a.Xuat();
            PhanSo b = new PhanSo();
            b.Nhap();
            b.Xuat();

            PhanSo c = a + b;
            Console.WriteLine("\nKet qua phep cong 2 phan so a va b: {0}",c.ToString());
            PhanSo d = a - b;
            Console.WriteLine("Ket qua phep tru 2 phan so a va b: {0}", d.ToString());
            PhanSo e = a * b;
            Console.WriteLine("Ket qua phep nhan 2 phan so a va b: {0}", e.ToString());
            PhanSo f = a / b;
            Console.WriteLine("Ket qua phep chia 2 phan so a va b: {0}", f.ToString());
            
            if (a == b)
            {
                Console.Write("Hai phan so a va b bang nhau : TRUE ");
            }
            else
            {
                Console.WriteLine("Hai phan so a va b bang nhau : FALSE ");
            }
            if(a != b)
            {
                Console.WriteLine("Hai phan so a va b khac nhau : TRUE ");
            }
            else
            {
                Console.WriteLine("Hai phan so a va b khac nhau : FALSE ");
            }
            PhanSo g = a ++;
            Console.WriteLine("Phan so a tang them 1 don vi : " + g.ToString());
            Console.ReadLine();
        }
    }
}
