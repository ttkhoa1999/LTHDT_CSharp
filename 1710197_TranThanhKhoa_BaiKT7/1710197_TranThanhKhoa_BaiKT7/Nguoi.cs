using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1710197_TranThanhKhoa_BaiKT7
{
    class Nguoi
    {
        string hoDem;
        string tenSV;
        string maSV;
        

        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }
        public string HoDem
        {
            get { return hoDem; }
            set { hoDem = value; }
        }
        public string TenSV
        {
            get { return tenSV; }
            set { tenSV = value; }
        }
       
        public Nguoi(string ma, string ho, string ten)
        {
            maSV = ma;
            hoDem = ho;
            tenSV = ten;
        }


    }
}
