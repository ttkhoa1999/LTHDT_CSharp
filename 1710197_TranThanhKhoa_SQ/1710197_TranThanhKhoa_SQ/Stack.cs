using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1710197_TranThanhKhoa_SQ
{
    class Stack : StackQueue
    {
        int[] mang;
        public Stack() : base()
        {
            mang = new int[100];
        }
        public int Pop()
        {
            if (!Empty())
                return Mang[n--];
            else
                return -int.MaxValue;
        }

    }
}
