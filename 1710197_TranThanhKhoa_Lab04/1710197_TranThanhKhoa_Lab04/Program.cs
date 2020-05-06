using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1710197_TranThanhKhoa_Lab04
{
    class Program
    {
        public class SoPhuc
        {
            float a = 0f , b = 0f;
            public SoPhuc()
            {

            }
            public SoPhuc(float a, float b)
            {
                this.a = a;
                this.b = b;
            }
            public void nhap()
            {   
                
                Console.WriteLine("\nNhap phan thuc: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap phan ao: ");
                b = int.Parse(Console.ReadLine());
            }
            public void xuat()
            {
                Console.WriteLine("So phuc vua nhap : "+a.ToString()+" + "+"("+b.ToString()+")*i");
            }
            public static SoPhuc operator +(SoPhuc ok1, SoPhuc ok2)
            {
                float aMoi = ok1.a + ok2.a;
                float bMoi = ok1.b + ok2.b;
                return new SoPhuc(aMoi,bMoi);
            }
            public static SoPhuc operator -(SoPhuc ok1, SoPhuc ok2)
            {
                float aMoi = ok1.a - ok2.a;
                float bMoi = ok1.b - ok2.b;
                return new SoPhuc(aMoi, bMoi);
            }
            public static SoPhuc operator *(SoPhuc ok1, SoPhuc ok2)
            {
                float aMoi = (ok1.a*ok2.a)-(ok1.b*ok2.b);
                float bMoi = (ok1.a*ok2.b)+(ok1.b*ok2.a);
                return new SoPhuc(aMoi, bMoi);
            }
            public static SoPhuc operator /(SoPhuc ok1, SoPhuc ok2)
            {
                float aMoi = (ok1.a * ok2.a + ok1.b * ok2.b) / (ok2.a * ok2.a + ok2.b * ok2.b);
                float bMoi = (ok1.b * ok2.a - ok1.a * ok2.b) / (ok2.a * ok2.a + ok2.b * ok2.b);
                return new SoPhuc(aMoi, bMoi);
            }
            public static explicit operator bool(SoPhuc ok)
            {
                return ok.a == 0;
            }
            public static bool operator ==(SoPhuc ok1,SoPhuc ok2)
            {
                return (ok1.a == ok2.a && ok1.b == ok2.b);
            }
            public static bool operator !=(SoPhuc ok1, SoPhuc ok2)
            {
                return !(ok1 == ok2);
            }
            public override string ToString()
            {
                return a.ToString()+" + "+"("+b.ToString()+")*i";
            }
        }
        static void Main(string[] args)
        {
            SoPhuc a = new SoPhuc();
            a.nhap();
            a.xuat();
            SoPhuc b = new SoPhuc();
            b.nhap();
            b.xuat();
            Console.WriteLine("\n====================================================");
            SoPhuc c = a + b;
            Console.WriteLine("\nKet qua phep cong 2 so phuc vua nhap: "+c.ToString());
            SoPhuc d = a - b;
            Console.WriteLine("Ket qua phep tru 2 so phuc vua nhap: " + d.ToString());
            SoPhuc e = a * b;
            Console.WriteLine("Ket qua phep nhan 2 so phuc vua nhap: " + e.ToString());
            SoPhuc f = a / b;
            Console.WriteLine("Ket qua phep chia 2 so phuc vua nhap: " + f.ToString());
            Console.WriteLine("\n====================================================");
            Console.WriteLine("Kiem tra so phuc la so thuc hay so thuan ao!!!");
            SoPhuc g = new SoPhuc();
            g.nhap();
            g.xuat();
            if (!(bool)g)
            {
                Console.WriteLine("So phuc nay la so thuc!!!");
            }
            else
            {
                Console.WriteLine("So phuc nay la so thuan ao!!!");
            }
            Console.WriteLine("\n====================================================");
            Console.WriteLine("So sanh 2 so phuc!!!");
            SoPhuc h = new SoPhuc();
            h.nhap();
            h.xuat();
            SoPhuc k = new SoPhuc();
            k.nhap();
            k.xuat();
            Console.WriteLine("Hai so phuc bang nhau: {0}", h == k);
            Console.WriteLine("Hai so phuc khac nhau: {0}", h != k);
            Console.ReadLine();
        }
    }
}
