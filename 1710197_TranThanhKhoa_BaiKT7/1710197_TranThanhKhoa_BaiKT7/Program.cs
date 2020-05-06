using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _1710197_TranThanhKhoa_BaiKT7
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
            LopHoc a = new LopHoc();
            a.NhapDS();
            a.Xuat();
            LopHoc kq = new LopHoc();
            string ho;
            Console.WriteLine("1. Tim sinh vien theo Ho");
            Console.Write("Nhap Ho Ten sinh vien can tim: ");
            ho = Console.ReadLine();
            kq = a.TimTheoHo(ho);
            kq.Xuat();

            string ten;
            Console.WriteLine("2. Tim tat ca sinh vien theo Ten");
            Console.Write("Nhap Ten sinh vien can tim: ");
            ten = Console.ReadLine();
            a.TimTatCaTheoTen(ten);
            string ma;
            Console.WriteLine("3. Tim sinh vien theo MSSV");
            Console.Write("Nhap MSSV can tim: ");
            ma = Console.ReadLine();
            kq = a.TimTheoMaSo(ma);
            kq.Xuat();

            LopHoc b = new LopHoc();
            Console.WriteLine("========================================= DANH SACH SINH VIEN DOC TU FILE =========================================");
            b.Read(@"C:\Users\ASUS\Desktop\C#\LAB\1710197_TranThanhKhoa_BaiKT7\1710197_TranThanhKhoa_BaiKT7\DuLieu.txt");
            b.Xuat();
            b.Write(@"C:\Users\ASUS\Desktop\C#\LAB\1710197_TranThanhKhoa_BaiKT7\1710197_TranThanhKhoa_BaiKT7\DuLieuSaoChep.txt");
            Console.WriteLine("\nMa Hoa Ma So Sinh Vien!");
            b.MaHoa();
            b.Xuat();
            Console.WriteLine("Giai Ma Ma So Sinh Vien!");
            b.GiaiMa();
            b.Xuat();
            Console.ReadLine();
        }
    }
}
