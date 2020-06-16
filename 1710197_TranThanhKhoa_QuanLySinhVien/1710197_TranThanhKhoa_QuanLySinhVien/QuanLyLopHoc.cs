using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1710197_TranThanhKhoa_QuanLySinhVien
{
    class QuanLyLopHoc:IODataBase,BaoMat
    {
        const int MAX = 100;
        QuanLySinhVien[] danhsach;
        int siSo;
        public QuanLyLopHoc()
        {
            siSo = 0;
            danhsach = new QuanLySinhVien[MAX];
        }
        public void Them(QuanLySinhVien sv)
        {
            danhsach[siSo] = sv;
            siSo++;
        }
        public void NhapDS()
        {
            string masv, holot, ten;
            //float diem; 
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
                /*do
                {
                    Console.Write("Nhap diem mon Toan: ");
                    diem = float.Parse(Console.ReadLine());
                } while (diem < 0 || diem > 10);*/
                Them(new QuanLySinhVien(masv, holot, ten));
            }
        }
        public QuanLyLopHoc TimTheoHoTen(string ho)
        {
            QuanLyLopHoc kq = new QuanLyLopHoc();

            for (int i = 0; i < siSo; i++)
            {
                if (danhsach[i].XuatHoLot() == ho)
                {
                    kq.Them(danhsach[i]);
                }
            }
            return kq;
        }
        public void TimTatCaTheoTen(string ten)
        {
                Console.WriteLine("\t\t\t\t\tDANH SACH SINH VIEN");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                for (int i = 0; i < siSo; i++)
                {
                    if (danhsach[i].XuatTen() == ten)
                    {
                        danhsach[i].Xuat();
                    }
                }
             Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            
        }
        public QuanLyLopHoc TimTheoMaSo(string ma)
        {
            QuanLyLopHoc kq = new QuanLyLopHoc();
            for (int i = 0; i < siSo; i++)
            {
                if (danhsach[i].XuatMaSoSV() == ma)
                {
                    kq.Them(danhsach[i]);
                }
            }
            return kq;
        }
        public void BoSungSinhVien()
        {
            Console.WriteLine("\n4. Them mot Sinh vien vao danh sach");
            string masv, holot, ten;
            //float diem;
            do
            {
                Console.Write("Nhap MSSV: ");
                masv = Console.ReadLine();
            } while (masv.Length != 7);

            Console.Write("Nhap Ho Lot: ");
            holot = Console.ReadLine();
            Console.Write("Nhap Ten: ");
            ten = Console.ReadLine();
            /*do
            {
                Console.Write("Nhap diem mon Toan: ");
                diem = float.Parse(Console.ReadLine());
            } while (diem < 0 || diem > 10);*/
            Them(new QuanLySinhVien(masv, holot, ten));
        }
        public QuanLySinhVien TimTheoMa(string ma)
        {
            for (int i = 0; i < siSo; i++)
            {
                if (danhsach[i].XuatMaSoSV() == ma)
                    return danhsach[i];
            }
            return null;
        }
        public void XoaSVTheoMa(string mssv) 
        {
            var ma = TimTheoMa(mssv);
            if(ma == null)
            {
                Console.WriteLine("Khong tim thay sinh vien co MSSV la: {0}", ma);
                return;
            }
            int i = 0;
            for ( i = 0; i < siSo; i++)
            {
                if (danhsach[i].MaSV == mssv)
                    break;
            }
            for (int j = i; j < siSo - 1; j++)
            {
                danhsach[j] = danhsach[j + 1];
                siSo -= 1;
            }
        }

        public void Read(string f)
        {
            FileStream fs = new FileStream(f, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string[] Arr;
            while (!sr.EndOfStream)
            {
                Arr = sr.ReadLine().Split('\t');
                Them(new QuanLySinhVien(Arr[0], Arr[1], Arr[2]));
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
                sw.WriteLine("{0}\t{1}\t{2}", danhsach[i].MaSV, danhsach[i].HoLot, danhsach[i].TenSV);
            }
            sw.Close();
            fs.Close();
            Console.WriteLine("Ghi thanh cong!");
        }
        public void MaHoa()
        {
            for (int i = 0; i < siSo; i++)
            {
                string kq = "";
                for (int j = 0; j < danhsach[i].MaSV.Length; j++)
                    kq = kq + (char)((int)danhsach[i].MaSV[j] + 5);
                danhsach[i].MaSV = kq;
            }
            for (int i = 0; i < siSo; i++)
            {
                string kq = "";
                for (int j = 0; j < danhsach[i].HoLot.Length; j++)
                    kq = kq + (char)((int)danhsach[i].HoLot[j] + 5);
                danhsach[i].HoLot = kq;
            }
            for (int i = 0; i < siSo; i++)
            {
                string kq = "";
                for (int j = 0; j < danhsach[i].TenSV.Length; j++)
                    kq = kq + (char)((int)danhsach[i].TenSV[j] + 5);
                danhsach[i].TenSV = kq;
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
            for (int i = 0; i < siSo; i++)
            {
                string kq = "";
                for (int j = 0; j < danhsach[i].HoLot.Length; j++)
                    kq = kq + (char)((int)danhsach[i].HoLot[j] - 5);
                danhsach[i].HoLot = kq;
            }
            for (int i = 0; i < siSo; i++)
            {
                string kq = "";
                for (int j = 0; j < danhsach[i].TenSV.Length; j++)
                    kq = kq + (char)((int)danhsach[i].TenSV[j] - 5);
                danhsach[i].TenSV = kq;
            }
        }
        public void Xuat()
        {
            Console.WriteLine("\t\t\t\t\tDANH SACH SINH VIEN");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");       
            for (int i = 0; i < siSo; i++)
            {
                danhsach[i].Xuat();
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------------");           
        }
    }
}
