using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1710197_TranThanhKhoa_SQ
{
    class Queue : StackQueue
    {
        int m;
        public Queue(int m) : base()
        {
            this.m = m;
        }
        public int Pop()
        {
            if (!Empty())
            {
                return Mang[m++] = 0;
            }
            return 0;
        }
    }
}
