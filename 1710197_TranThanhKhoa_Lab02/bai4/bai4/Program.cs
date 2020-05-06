using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Trong phuong thuc Swap: a = {0}, b = {1}", a, b);
        }
        static void Main(string[] args)
        {
            int x = 3, y = 4;
            Console.WriteLine("Truoc khi goi phuong thuc Swap: x = {0}, y = {1} ", x, y);
            Swap(ref x, ref y);
            Console.WriteLine("Sau khi goi phuong thuc Swap: x = {0}, y = {1}", x, y);
            Console.ReadLine();
        }
        // Phương thức swap không có ref thì sau khi swap kết quả sẽ trở về ban đầu
        // còn nếu có ref thì sẽ giữ nguyên kết quả sau khi swap
    }
}
