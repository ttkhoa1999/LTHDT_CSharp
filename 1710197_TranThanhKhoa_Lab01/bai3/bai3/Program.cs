using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class Program
    {
        class myclass
        {
            int dai, rong;
            public void set_HCN()
            {
                Console.WriteLine("Nhap chieu dai cua HCN : ");
                dai = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap chieu rong cua HCN : ");
                rong = int.Parse(Console.ReadLine());
            }
            public int getChuVi()
            {
                return (dai + rong) * 2;
            }
            public int getDienTich()
            {
                return dai * rong;
            }
        }
        static void Main(string[] args)
        {
            myclass k = new myclass();
            k.set_HCN();
            Console.WriteLine("Chu vi HCN la : " + k.getChuVi());
            Console.WriteLine("Dien tich HCN la : " + k.getDienTich());
            Console.ReadLine();
            return;
        }
    }
}
