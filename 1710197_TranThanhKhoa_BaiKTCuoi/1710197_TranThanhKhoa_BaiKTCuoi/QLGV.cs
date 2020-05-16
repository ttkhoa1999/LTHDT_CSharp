using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1710197_TranThanhKhoa_BaiKTCuoi
{
    class QLGV:IODataBase,BaoMat
    {
        const int MAX = 100;
        GiaoVien[] danhsach;
        int tongSo;

        public QLGV()
        {
            tongSo = 0;
            danhsach = new GiaoVien[MAX];
        }

        public void Them(GiaoVien gv)
        {
            danhsach[tongSo] = gv;
            tongSo++;
        }

        public void NhapDS()
        {
            string maso, holot, ten, bm;
            Console.Write("Nhap tong so giao vien: ");
            int s = int.Parse(Console.ReadLine());
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine("Nhap thong tin cho giao vien thu {0}", i + 1);
                do
                {
                    Console.Write("Nhap Ma So: ");
                    maso = Console.ReadLine();
                } while (maso.Length != 7);
                Console.Write("Nhap Ho Lot: ");
                holot = Console.ReadLine();
                Console.Write("Nhap Ten: ");
                ten = Console.ReadLine();
                Console.Write("Nhap Bo Mon: ");
                bm = Console.ReadLine();
                Them(new GiaoVien(maso, holot, ten, "", bm));
            }
        }

        public QLGV TimTheoHo(string ho)
        {
            QLGV kq = new QLGV();
            for (int i = 0; i < tongSo; i++)
            {
                if (danhsach[i].XuatHoLot() == ho)
                    kq.Them(danhsach[i]);
            }
            return kq;
        }

        public void TimTatCaTheoTen(string ten)
        {
            Console.WriteLine("\t\t\t\t\t\t\tDANH SACH GIAO VIEN");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < tongSo; i++)
            {
                if (danhsach[i].XuatTen() == ten)
                {
                    danhsach[i].Xuat();
                }
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
        }

        public QLGV TimTheoMaSo(string ma)
        {
            QLGV kq = new QLGV();
            for (int i = 0; i < tongSo; i++)
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
                Them(new GiaoVien(arr[0], arr[1], arr[2], "", arr[4]));
            }
            sr.Close();
            fs.Close();
        }

        public void Write(string f)
        {
            FileStream fs = new FileStream(f, FileMode.Open);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < tongSo; i++)
            {
                sw.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", danhsach[i].MaGV, danhsach[i].HoDem, danhsach[i].TenGV, danhsach[i].iD, danhsach[i].BoMon);
            }
            sw.Close();
            fs.Close();
            Console.WriteLine("Ghi thanh cong!");
        }
        public void MaHoa()
        {
            for (int i = 0; i < tongSo; i++)
            {
                string kq = "";
                for (int j = 0; j < danhsach[i].MaGV.Length; j++)
                    kq = kq + (char)((int)danhsach[i].MaGV[j] + 5);
                danhsach[i].MaGV = kq;
            }
        }
        public void GiaiMa()
        {
            for (int i = 0; i < tongSo; i++)
            {
                string kq = "";
                for (int j = 0; j < danhsach[i].MaGV.Length; j++)
                    kq = kq + (char)((int)danhsach[i].MaGV[j] - 5);
                danhsach[i].MaGV = kq;
            }
        }
        public void Xuat()
        {
            Console.WriteLine("\t\t\t\t\t\t\tDANH SACH GIAO VIEN");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < tongSo; i++)
            {
                danhsach[i].Xuat();
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
        }
    }
}
