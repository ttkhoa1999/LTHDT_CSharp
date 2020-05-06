using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    class Program
    {
        class myclass
        {
            public int a, b;
            public myclass()
            {
                a = 3;
                b = 7;
            }
            public void show()
            {
                Console.WriteLine("Phan so da cho : {0}/{1}",a,b);
            }
        }
        static void Main(string[] args)
        {
            myclass k = new myclass();
            k.show();
            Console.ReadLine();
            return;
        }
    }
}
