using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1710197_TranThanhKhoa_QuanLySinhVien
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
            QuanLyLopHoc a = new QuanLyLopHoc();
            a.NhapDS();
            a.Xuat();
            QuanLyLopHoc kq = new QuanLyLopHoc();
            string ho;
            Console.WriteLine("1. Tim sinh vien theo Ho Ten");
            Console.Write("Nhap Ho Ten sinh vien can tim: ");
            ho = Console.ReadLine();
            kq = a.TimTheoHoTen(ho);
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
            a.BoSungSinhVien();
            a.Xuat();
            string masv;
            Console.Write("\n5. Nhap MSSV cua sinh vien can xoa: ");
            masv = Console.ReadLine();
            a.XoaSVTheoMa(masv);
            a.Xuat();
            QuanLyLopHoc b = new QuanLyLopHoc();
            Console.WriteLine("================================= DANH SACH SINH VIEN DOC TU FILE =================================");
            b.Read(@"C:\Users\ASUS\Desktop\C#\LAB\1710197_TranThanhKhoa_QuanLySinhVien\1710197_TranThanhKhoa_QuanLySinhVien\DuLieu.txt");
            b.Xuat();
            b.Write(@"C:\Users\ASUS\Desktop\C#\LAB\1710197_TranThanhKhoa_QuanLySinhVien\1710197_TranThanhKhoa_QuanLySinhVien\DuLieuSaoChep.txt");
            Console.WriteLine("Ma Hoa thong tin!");
            b.MaHoa();
            b.Xuat();
            Console.WriteLine("Giai Ma thong tin!");
            b.GiaiMa();
            b.Xuat();
            Console.ReadLine();
        }
    }
}
