using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1710197_TranThanhKhoa_BaiKTCuoi
{
    class GiaoVien:Nguoi
    {
        string ID;
        string boMon;
        public GiaoVien(string ma, string ho, string ten, string id, string bm) : base(ma, ho, ten)
        {
            ID = id;
            boMon = bm;
        }

        public string iD
        {
            get { return "Giao Vien"; }
            set { ID = value; }
        }

        public string BoMon
        {
            get { return boMon; }
            set { boMon = value; }
        }
        public string XuatTen()
        {
            return TenGV;
        }
        public string XuatHoLot()
        {
            return HoDem;
        }
        public string XuatMaSoSV()
        {
            return MaGV;
        }
        public void Xuat()
        {
            Console.WriteLine("Ma So: {0} \t\t Ho Lot: {1} \t\t Ten: {2} \t\t ID: {3} \t\t Bo Mon: {4} ", MaGV, HoDem, TenGV, iD, BoMon);
        }
    }
}
