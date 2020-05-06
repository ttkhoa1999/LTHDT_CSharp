using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    class Program
    {
        class PhanSo
        {
            int tuso, mauso;
            public void nhap()
            {
                Console.WriteLine("Nhap vao tu so : ");
                tuso = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap vao mau so : ");
                mauso = int.Parse(Console.ReadLine());
            }
            public void show()
            {
                do
                {
                    if (mauso == 0)
                    {
                        Console.WriteLine("Khong hop le !!! Nhap lai : ");
                        Console.WriteLine("Nhap vao tu so : ");
                        tuso = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap vao mau so :");
                        mauso = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Phan so vua nhap la: {0}/{1}", tuso, mauso);
                        break;
                    }
                } while (mauso != 0);
            }
        }
        static void Main(string[] args)
        {
            PhanSo k = new PhanSo();
            k.nhap();
            k.show();
            Console.ReadLine();
        }
    }
}
