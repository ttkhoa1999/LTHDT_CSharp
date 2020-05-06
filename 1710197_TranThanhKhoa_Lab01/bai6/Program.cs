using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    class Program
    {
        class myclass
        {
            public int a, b;
            public myclass(int tuso, int mauso)
            {
                a = tuso;
                b = mauso;
            }
            public void show()
            {
                Console.WriteLine("Phan so da cho : {0}/{1}", a, b);
            }
        }
        static void Main(string[] args)
        {
            myclass k = new myclass(6, 6);
            k.show();
            Console.ReadLine();
            return;
        }
    }
}
