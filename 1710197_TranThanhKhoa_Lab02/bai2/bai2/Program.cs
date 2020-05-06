using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        class myclass
        {
            public static int i;
            //private static int i;
            public void seti(int n)
            {
                i = n;
            }
            public int geti()
            {
                return i;
            }
        }
        static void Main(string[] args)
        {
            myclass.i = 100;
            myclass ob1 = new myclass();
            myclass ob2 = new myclass();
            //ob1.seti(10);
            Console.WriteLine("Gia tri ob1: {0}",ob1.geti());
            Console.WriteLine("Gia tri ob2: {0}",ob2.geti());
            Console.ReadLine();
        }
        // Đối tượng ob2 cũng có giá trị 10 vì đối tượng ob2 đã sử dụng chung biến static i nên không cần khởi gán cho ob2.
        // Biến i có thành phần static đặt ở public được truy cập đến và gán giá trị mà không cần phụ thuộc vào đối tượng nào cả.
    }
}
