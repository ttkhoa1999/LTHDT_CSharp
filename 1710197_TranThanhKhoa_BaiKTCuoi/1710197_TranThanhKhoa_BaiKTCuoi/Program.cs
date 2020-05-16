using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1710197_TranThanhKhoa_BaiKTCuoi
{
    interface IODataBase
    {
        void Read(string f);
        void Write(string f);
    }
    interface BaoMat
    {
        void MaHoa();
        void GiaiMa();
    }
    class Program
    {
        static void Main(string[] args)
        {
            QLGV a = new QLGV();
            a.NhapDS();
            a.Xuat();
            QLGV kq = new QLGV();
            string ho;
            Console.WriteLine("1. Tim giao vien theo Ho");
            Console.Write("Nhap Ho Ten giao vien can tim: ");
            ho = Console.ReadLine();
            kq = a.TimTheoHo(ho);
            kq.Xuat();

            string ten;
            Console.WriteLine("2. Tim tat ca giao vien theo Ten");
            Console.Write("Nhap Ten giao vien can tim: ");
            ten = Console.ReadLine();
            a.TimTatCaTheoTen(ten);
            string ma;
            Console.WriteLine("3. Tim giao vien theo Ma So");
            Console.Write("Nhap Ma So Giao Vien can tim: ");
            ma = Console.ReadLine();
            kq = a.TimTheoMaSo(ma);
            kq.Xuat();

            QLGV b = new QLGV();
            Console.WriteLine("================================================ DANH SACH GIAO VIEN DOC TU FILE ===============================================");
            b.Read(@"C:\Users\ASUS\Desktop\C#\LAB\LTHDT_CSharp\1710197_TranThanhKhoa_BaiKTCuoi\1710197_TranThanhKhoa_BaiKTCuoi\DuLieu.txt");
            b.Xuat();
            b.Write(@"C:\Users\ASUS\Desktop\C#\LAB\LTHDT_CSharp\1710197_TranThanhKhoa_BaiKTCuoi\1710197_TranThanhKhoa_BaiKTCuoi\DuLieuSaoChep.txt");
            Console.WriteLine("\nMa Hoa Ma So Giao Vien!");
            b.MaHoa();
            b.Xuat();
            Console.WriteLine("Giai Ma Ma So Giao Vien!");
            b.GiaiMa();
            b.Xuat();
            Console.ReadLine();
        }
    }
}
