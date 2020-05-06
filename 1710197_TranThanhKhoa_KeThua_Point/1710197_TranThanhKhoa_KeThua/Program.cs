using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1710197_TranThanhKhoa_KeThua
{
    class Program
    {
        class Point2D
        {
            protected int x, y;
            public void setxy(int toadoX, int toadoY)
            {
                x = toadoX;
                y = toadoY;
            }
            public void Xuat2D()
            {
                Console.WriteLine("({0}, {1})", x, y);
            }
        }
        class Point3D : Point2D
        {
            int z;
            public void setxyz(int toadoX, int toadoY, int toadoZ)
            {
                x = toadoX;
                y = toadoY;
                z = toadoZ;
            }
            public void Xuat3D()
            {
                Console.WriteLine("({0}, {1}, {2})", x, y, z);
            }
        }
        static void Main(string[] args)
        {
            Point2D p2 = new Point2D();
            p2.setxy(1, 2);
            p2.Xuat2D();
            Point3D p3 = new Point3D();
            p3.setxyz(3, 4, 5);
            p3.Xuat3D();
            p3.Xuat2D();
            Console.ReadLine();
        }
    }
}
