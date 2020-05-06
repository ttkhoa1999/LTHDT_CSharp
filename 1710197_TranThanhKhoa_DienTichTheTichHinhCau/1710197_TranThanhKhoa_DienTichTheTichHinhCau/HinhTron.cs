using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1710197_TranThanhKhoa_DienTichTheTichHinhCau
{
    class HinhTron
    {
        bool kiemtra = false;
        protected double Pi;
        protected double R;
        public HinhTron()
        {
            Pi = 3.14;
        }
        public void Nhap()
        {
            do
            {
                Console.Write("Nhap ban kinh R = ");
                kiemtra = double.TryParse(Console.ReadLine(), out R);
            } while (!kiemtra);
        }
        public double DienTich()
        {
            double S = Pi * R * R;
            return S;
        }
    }
}
