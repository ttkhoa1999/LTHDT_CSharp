using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1710197_TranThanhKhoa_BaiKT7
{
    class SinhVien:Nguoi
    {
        string ID;
        string Lop;
        public SinhVien(string ma, string ho, string ten, string id, string lop) : base(ma, ho, ten)
        {
            ID = id;
            Lop = lop;
        }
        
        public string iD
        {
            get { return "Sinh Vien"; }
            set { ID = value; }
        }

        public string LopHoc
        {
            get { return Lop; }
            set { Lop = value; }
        }
        public string XuatTen()
        {
            return TenSV;
        }
        public string XuatHoLot()
        {
            return HoDem;
        }
        public string XuatMaSoSV()
        {
            return MaSV;
        }
        public void Xuat()
        {
            Console.WriteLine("MSSV: {0} \t\t Ho Lot: {1} \t\t Ten: {2} \t\t ID: {3} \t\t Lop: {4} ", MaSV, HoDem, TenSV, iD, LopHoc);
        }
    }
}
