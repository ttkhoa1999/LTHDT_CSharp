using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1710197_TranThanhKhoa_DaThuc
{
    class DaThuc
    {
        public int bac;
        public double[] heso;
        public DaThuc()
        {
            heso = new double[100];
        }
        DaThuc(int m)
        {
            bac = m;
            heso = new double[bac + 1];
        }
      
        public void Nhap()
        {
            bool kiemtra = false;
            while (!kiemtra)
            {
                Console.Write("Nhap vao bac cua da thuc: ");
                kiemtra = Int32.TryParse(Console.ReadLine(), out bac);
            }
            Console.WriteLine("Nhap vao cac he so cua da thuc: ");
            for (int i = 0; i <= bac ; i++)
            {
                Console.Write("He so thu {0}: ", i);
                heso[i] =int.Parse(Console.ReadLine());
            }
        }
        public void Xuat()
        {    
            for (int i = bac; i > 0; i--)
            {
                Console.Write("({0})x^{1} + ", heso[i], bac--);
            }
            Console.Write("{0} ", heso[0]);
        }

        public DaThuc congDaThuc(DaThuc a)
        {
            DaThuc b;
            int i, j;
            if (bac > a.bac)
            {
                b = new DaThuc(bac);
                for (i = 0; i <= a.bac; i++)
                {
                    b.heso[i] = heso[i] + b.heso[i];
                }
                for (j = i; j <= bac; i++)
                {
                    b.heso[j] = heso[j];
                }
            }
            else
            {
                b = new DaThuc(a.bac);
                for (i = 0; i <= bac; i++)
                    b.heso[i] = heso[i] + a.heso[i];
                for (j = i; j <= a.bac; j++)
                    b.heso[j] = a.heso[j];
            }

            return b;

        }
        public static DaThuc operator +(DaThuc a, DaThuc b)
        {
            DaThuc c = new DaThuc();
            for (int i = 0; i <= c.bac; i++)
            {
                c.heso[i] = a.heso[i] + b.heso[i];
            }
            return c;
        }
        public DaThuc truDaThuc(DaThuc a)
        {
            DaThuc b;
            int i, j;
            if (bac > a.bac)
            {
                b = new DaThuc(bac);
                for (i = 0; i <= a.bac; i++)
                {
                    b.heso[i] = heso[i] - b.heso[i];
                }
                for (j = i; j <= bac; i++)
                {
                    b.heso[j] = heso[j];
                }
            }
            else
            {
                b = new DaThuc(a.bac);
                for (i = 0; i <= bac; i++)
                    b.heso[i] = heso[i] - a.heso[i];
                for (j = i; j <= a.bac; j++)
                    b.heso[j] = a.heso[j];
            }

            return b;

        }
        public static DaThuc operator -(DaThuc a, DaThuc b)
        {
            DaThuc c = new DaThuc();
            int maxbac = Math.Max(a.bac, b.bac);
            for (int i = 0; i <= c.bac; i++)
            {
                c.heso[i] = a.heso[i] - b.heso[i];
            }
            return c;
        }

    }
}
