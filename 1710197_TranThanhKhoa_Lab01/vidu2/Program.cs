using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidu2
{
    class Program
    {
        class myclass
        {
            public int a;

            public void set_a(int num)
            {
                a = num;
            }
            public int get_a()
            {
                return a;
            }
        }
        static void Main(string[] args)
        {
            myclass ob1 = new myclass();
            myclass ob2 = new myclass();
            ob1.a = 10;
            ob2.set_a(99);
            Console.WriteLine("Gia tri a cua doi tuong ob1: {0}", ob1.a);
            Console.WriteLine("Gia tri a cua doi tuong ob2: {0}", ob2.get_a());
            Console.ReadLine();
            return;
        }

        //Sử dụng thành phần dữ liệu là public cho phép truy cập, nhập dữ liệu từ bên ngoài đối tượng mà không cần thông qua phương thức.
        //Việc sử dụng thành phần dữ liệu private thể hiện tính đóng gói trong lập trình hướng đối tượng.
    }
}
