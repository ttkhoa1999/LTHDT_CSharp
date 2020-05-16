using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1710197_TranThanhKhoa_BaiKTCuoi
{
    class Nguoi
    {

        string hoDem;
        string tenGV;
        string maSo;


        public string MaGV
        {
            get { return maSo; }
            set { maSo = value; }
        }
        public string HoDem
        {
            get { return hoDem; }
            set { hoDem = value; }
        }
        public string TenGV
        {
            get { return tenGV; }
            set { tenGV = value; }
        }

        public Nguoi(string ma, string ho, string ten)
        {
            maSo = ma;
            hoDem = ho;
            tenGV = ten;
        }

    }
}
