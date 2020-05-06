using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1710197_TranThanhKhoa_DienTichTheTichHinhCau
{
    class HinhCau : HinhTron 
    {
        public HinhCau() : base()
        {

        }
        public new double DienTich()
        {
            double S = 4 * Pi * R * R;
            return S;
        }
        public double TheTich()
        {
            double V = (4 * Pi * R * R * R)/3;
            return V;
        }
    }
}
