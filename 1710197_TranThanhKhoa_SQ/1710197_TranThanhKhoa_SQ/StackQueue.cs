using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1710197_TranThanhKhoa_SQ
{
    class StackQueue
    {
        protected const int size = 100;
        protected int[] Mang;
        protected int n;
        public StackQueue()
        {
            Mang = new int[size];
            n = 0;
        }
        public bool Empty()
        {
            return (n == 0);
        }
        public bool Full()
        {
            return (n == size);
        }
        public void Push(int p)
        {
            if (!Full())
                Mang[n++] = p;
            else
                Console.WriteLine("Mang da full! ");
        }
        public void Show()
        {
            for (int i = 0; i < n; i++)
                Console.Write("\t" + Mang[i]);
            Console.WriteLine();
        }
    }
}
