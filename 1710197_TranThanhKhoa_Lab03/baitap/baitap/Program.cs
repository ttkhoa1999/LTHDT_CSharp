using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap
{
    class Program
    {
        public class TamThuc
        {
            int a, b, c;
            private int t4;
            private int t5;

            public TamThuc()
            {
                a = b = c = 0;
            }

            public TamThuc(int a, int b, int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public TamThuc(TamThuc ob)
            {
                ob.a = a;
                ob.b = b;
                ob.c = c;
            }

            public TamThuc(int a, int b, int c, int t4, int t5) : this(a, b, c)
            {
                this.t4 = t4;
                this.t5 = t5;
            }

            public void nhap()
            {
                bool kiemtra = false;
                do
                {
                    Console.Write("Nhap gia tri cua a: ");
                    kiemtra = Int32.TryParse(Console.ReadLine(), out a);
                    if (a != 0)
                    {
                        Console.Write("\nNhap gia tri cua b: ");
                        kiemtra = Int32.TryParse(Console.ReadLine(), out b);
                        Console.Write("\nNhap gia tri cua c: ");
                        kiemtra = Int32.TryParse(Console.ReadLine(), out c);
                    }
                } while (a == 0);
            
            }
            public void xuat()
            {
                Console.WriteLine("\nTam Thuc vua nhap: "+"("+a.ToString()+")x^2 + "+"("+b.ToString()+")"+"x + "+"("+c.ToString()+")");
            }
            public void xuattamthuc3chuso()
            {
                Console.WriteLine("\nTam Thuc tach 3 so tu so nguyen vua nhap: " + "(" + a.ToString() + ")x^2 + " + "(" + b.ToString() + ")" + "x + " + "(" + c.ToString() + ")");
            }
            public void xuatnhantamthuc()
            {
                Console.WriteLine("" + "(" + a.ToString() + ")x^4 + " + "(" + b.ToString() + ")" + "x^3 + " + "(" + c.ToString() + ")"+"x^2 + "+"(" + t4.ToString() + ")" + "x + " +"("+ t5.ToString()+")");
            }
            public static TamThuc operator +(TamThuc ob1, TamThuc ob2)
            {
                int aMoi = ob1.a + ob2.a;
                int bMoi = ob1.b + ob2.b;
                int cMoi = ob1.c + ob2.c;
                TamThuc ob3 = new TamThuc(aMoi, bMoi, cMoi);
                return ob3;
            }
            public static TamThuc operator -(TamThuc ob1, TamThuc ob2)
            {
                int aMoi = ob1.a - ob2.a;
                int bMoi = ob1.b - ob2.b;
                int cMoi = ob1.c - ob2.c;
                TamThuc ob3 = new TamThuc(aMoi, bMoi, cMoi);
                return ob3;
            }

            public static explicit operator bool(TamThuc ob)
            {
                return (ob.b * ob.b - 4 * ob.a * ob.c) >= 0;
            }
             public static implicit operator TamThuc(int number)
             {
                int a = number / 100;
                int b = (number % 100) / 10;
                int c = (number % 100) % 10;
                return new TamThuc(a, b, c);
            }
             
            public static TamThuc operator *(TamThuc ob1, TamThuc ob2)
            {
                int t1 = ob1.a * ob2.a;
                int t2 = (ob1.a * ob2.b) + (ob1.b * ob2.a);
                int t3 = (ob1.a * ob2.c) + (ob1.b * ob2.b) + (ob1.c * ob2.a);
                int t4 = (ob1.b * ob2.c) + (ob1.c * ob2.b);
                int t5 = ob1.c * ob2.c;
                TamThuc ob3 = new TamThuc(t1,t2,t3,t4,t5);
                return ob3;
            }
            public static TamThuc operator ++(TamThuc ob)
            {
                ob.c = ob.c + 1;
                return ob;
            }
            public static bool  operator ==(TamThuc ob1, TamThuc ob2)
            {
                return (ob1.a == ob2.a && ob1.b == ob2.b && ob1.c == ob2.c);
            }
            public static bool operator !=(TamThuc ob1, TamThuc ob2)
            {
                return !(ob1 == ob2);
            }

            public override string ToString()
            {
                String s = "(" + a.ToString() + ")x^2 + " + "(" + b.ToString() + ")" + "x + " + "(" + c.ToString() + ")";
                return s;
            }
        }
        static void Main(string[] args)
        {
            TamThuc a = new TamThuc();
            a.nhap();
            a.xuat();
            Console.WriteLine();
            TamThuc b = new TamThuc();
            b.nhap();
            b.xuat();
            TamThuc c = a + b;
            Console.WriteLine("Phep cong 2 tam thuc: "+c.ToString());
            TamThuc d = a - b;
            Console.WriteLine("Phep tru 2 tam thuc: "+d.ToString());
            Console.WriteLine("\nNhap Tam Thuc moi de kiem tra nghiem !!!! ");
            TamThuc v = new TamThuc();
            v.nhap();
            v.xuat();
            bool nghiem = (bool)v;
            Console.WriteLine("Tam thuc co nghiem : {0} ", nghiem);
            TamThuc z = new TamThuc();
            Console.WriteLine("Nhap mot so co 3 chu so: ");
            int so = int.Parse(Console.ReadLine());
            while (so != 0)
            {
                if (so <= 99 || so > 999)
                {
                    Console.WriteLine("Nhap lai : ");
                    so = int.Parse(Console.ReadLine());
                }
                else
                    break;
            } 
            z = so;
            z.xuattamthuc3chuso();
            TamThuc e = a * b;
            Console.Write("Phep nhan tam thuc a voi tam thuc b : ");
            e.xuatnhantamthuc();
            Console.WriteLine("Hai Tam Thuc a va b khac nhau : {0}", a != b);

            TamThuc f = a ++;
            Console.WriteLine("Tam thuc a cong them 1: "+ f.ToString());
           
            Console.ReadLine();
        }
    }
}
