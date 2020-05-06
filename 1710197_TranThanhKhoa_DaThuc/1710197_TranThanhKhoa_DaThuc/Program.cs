using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1710197_TranThanhKhoa_DaThuc
{
    class Program:DaThuc
    {
       
        static void Main(string[] args)
        {
            DaThuc dt = new DaThuc();
            Console.WriteLine("\tNhap vao da thuc thu nhat!!! ");
            dt.Nhap();
            Console.Write("Da thuc vua nhap: ");
            dt.Xuat();
            DaThuc dt1 = new DaThuc();
            Console.WriteLine("\t\nNhap vap da thuc thu hai!!! ");
            dt1.Nhap();
            Console.Write("Da thuc vua nhap: ");
            dt1.Xuat();
            Console.Write("\nTong 2 da thuc: ");
            DaThuc tong = new DaThuc();
            tong = dt.congDaThuc(dt1);
            tong.XuatKQ();
            Console.Write("\nOperator tong 2 da thuc: ");
            tong = dt + dt1;
            tong.XuatKQ();
            Console.Write("\nHieu 2 da thuc: ");
            DaThuc hieu = new DaThuc();
            hieu = dt.truDaThuc(dt1);
            hieu.Xuat();
            Console.Write("\nOperator hieu 2 da thuc: ");
            hieu = dt - dt1;
            hieu.Xuat();
            Console.ReadLine();
        }
    }
}
