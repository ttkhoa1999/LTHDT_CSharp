using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1710197_TranThanhKhoa_BaiKT7
{
    class LopHoc:IODataBase,BaoMat
    {
        const int MAX = 100;
        SinhVien[] danhsach;
        int siSo;

        public LopHoc()
        {
            siSo = 0;
            danhsach = new SinhVien[MAX];
        }

        public void Them(SinhVien sv)
        {
            danhsach[siSo] = sv;
            siSo++;
        }

        public void NhapDS()
        {
            string masv, holot, ten, lop;
            Console.Write("Nhap si so cua lop: ");
            int s = int.Parse(Console.ReadLine());
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine("Nhap thong tin cho sinh vien thu {0}", i + 1);
                do
                {
                    Console.Write("Nhap MSSV: ");
                    masv = Console.ReadLine();
                } while (masv.Length != 7);

                Console.Write("Nhap Ho Lot: ");
                holot = Console.ReadLine();
                Console.Write("Nhap Ten: ");
                ten = Console.ReadLine();
                do
                {
                    Console.Write("Nhap Lop: ");
                    lop = Console.ReadLine();
                } while (lop.Length != 5);
                Them(new SinhVien(masv, holot, ten, "", lop));
            }
        }

        public LopHoc TimTheoHo(string ho)
        {
            LopHoc kq = new LopHoc();
            for (int i = 0; i < siSo; i++)
            {
                if (danhsach[i].XuatHoLot() == ho)
                    kq.Them(danhsach[i]);
            }
            return kq;
        }

        public void TimTatCaTheoTen(string ten)
        {
            Console.WriteLine("\t\t\t\t\t\tDANH SACH SINH VIEN");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < siSo; i++)
            {
                if (danhsach[i].XuatTen() == ten)
                {
                    danhsach[i].Xuat();
                }
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
        }
        
        public LopHoc TimTheoMaSo(string ma)
        {
            LopHoc kq = new LopHoc();
            for (int i = 0; i < siSo; i++)
            {
                if (danhsach[i].XuatMaSoSV() == ma)
                    kq.Them(danhsach[i]);
            }
            return kq;
        }

        public void Read(string f)
        {
            FileStream fs = new FileStream(f, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string[] arr;
            while (!sr.EndOfStream)
            {
                arr = sr.ReadLine().Split('\t');
                Them(new SinhVien(arr[0], arr[1], arr[2], "", arr[4]));
            }
            sr.Close();
            fs.Close();
        }

        public void Write(string f)
        {
            FileStream fs = new FileStream(f, FileMode.Open);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < siSo; i++)
            {
                sw.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", danhsach[i].MaSV, danhsach[i].HoDem, danhsach[i].TenSV, danhsach[i].iD, danhsach[i].LopHoc);
            }
            sw.Close();
            fs.Close();
            Console.WriteLine("Ghi thanh cong!");
        }
        public void MaHoa()
        {
            for(int i = 0; i < siSo; i++)
            {
                string kq = "";
                for (int j = 0; j < danhsach[i].MaSV.Length; j++)
                    kq = kq + (char)((int)danhsach[i].MaSV[j] + 5);
                danhsach[i].MaSV = kq;
            }
        }
        public void GiaiMa()
        {
            for (int i = 0; i < siSo; i++)
            {
                string kq = "";
                for (int j = 0; j < danhsach[i].MaSV.Length; j++)
                    kq = kq + (char)((int)danhsach[i].MaSV[j] - 5);
                danhsach[i].MaSV = kq;
            }
        }
        public void Xuat()
        {
            Console.WriteLine("\t\t\t\t\t\tDANH SACH SINH VIEN");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < siSo; i++)
            {
                danhsach[i].Xuat();
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
        }
    }
}
