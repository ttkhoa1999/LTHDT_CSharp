using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1710197_TranThanhKhoa_DienTichTheTichHinhCau
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhCau C = new HinhCau();
            C.Nhap();
            Console.WriteLine("\nDien tich hinh cau: S = {0}", C.DienTich());
            Console.WriteLine("\nThe tich hinh cau: V = {0}", C.TheTich());
            Console.ReadLine();
        }
    }
}
