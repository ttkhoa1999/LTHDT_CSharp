using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1710197_TranThanhKhoa_KeThua_XeKhachXeHoi
{
    class Program
    {
        class XeHoi
        {
            protected int TocDo;
            protected string BienSo;
            protected string HangSX;
            public XeHoi(int td, string BS, string HSX)
            {
                TocDo = td;
                BienSo = BS;
                HangSX = HSX;
            }
            public void Xuat()
            {
                Console.Write("Xe: {0}, Bien so: {1}, Toc do: {2} km/h", HangSX, BienSo, TocDo);
            }
        
        }
        class XeKhach : XeHoi
        {
            int SoHanhKhach;

            public XeKhach(int td, string BS, string HSX, int SHK) : base(td, BS, HSX)
            {
                SoHanhKhach = SHK;
            }
            public new void Xuat()
            {
                base.Xuat();
                Console.WriteLine(", {0} cho ngoi", SoHanhKhach);
            }
          
        }
        static void Main(string[] args)
        {
            XeKhach c = new XeKhach(150, "49A-444", "Toyota", 24);
            c.Xuat();
            Console.WriteLine();
            Console.WriteLine("Tham chieu cua lop co so XeHoi co the tro den doi tuong thuoc lop dan xuat XeKhach");
            Console.WriteLine("Nhung chi co the goi trong ham xuat tuong ung voi XeHoi");
            XeHoi h = c;
            h.Xuat();
            Console.ReadLine();
        }
    }
}
