﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidu1
{
    class Program
    {
        class myclass
        {
            int a;
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
            ob1.set_a(10);
            ob2.set_a(99);
            Console.WriteLine("Gia tri a cua doi tuong ob1: {0}", ob1.get_a());
            Console.WriteLine("Gia tri a cua doi tuong ob2: {0}", ob2.get_a());
            Console.ReadLine();
        }

        //Giá trị thành phần của 2 đối tượng được tạo ra tuy dùng chung 1 phương thức nhưng trả về hoàn toàn khác nhau.
    }
}
