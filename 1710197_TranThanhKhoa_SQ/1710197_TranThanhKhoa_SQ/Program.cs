using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1710197_TranThanhKhoa_SQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack S = new Stack();
            S.Push(1);
            S.Push(2);
            S.Push(3);
            S.Push(4);
            S.Push(5);
            Console.Write("Phan tu trong Stack: ");
            S.Show();
            Console.Write("\nSau khi lay ra: ");
            S.Pop();
            S.Show();
            Queue Q = new Queue(0);
            Q.Push(6);
            Q.Push(7);
            Q.Push(8);
            Q.Push(9);
            Q.Push(10);
            Console.Write("\nPhan tu trong Queue: ");
            Q.Show();
            Console.Write("\nSau khi lay ra: ");
            Q.Pop();
            Q.Show();

            Console.ReadLine();
        }
    }
}
