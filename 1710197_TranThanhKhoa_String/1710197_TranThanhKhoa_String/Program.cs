using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1710197_TranThanhKhoa_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            Console.Write("-----------------------------------\n");
            Console.Write("Nhap chuoi A: ");
            str1 = Console.ReadLine();
            Console.Write("Chuoi A vua nhap: {0}\n", str1);
            string str2;
            Console.Write("-----------------------------------\n");
            Console.Write("Nhap chuoi B: ");
            str2 = Console.ReadLine();
            Console.Write("Chuoi B vua nhap: {0}\n", str2);
            //So sanh 2 chuoi
            Console.Write("-----------------------------------\n");
            Console.WriteLine("So sanh 2 chuoi A va B");
            if (String.Compare(str1, str2, true) == 0)
            {
                Console.Write("Giong nhau");
            }
            else if (String.Compare(str1, str2, true) < 0)
            {
                Console.Write("Chuoi A nho hon chuoi B");
            }
            //Noi chuoi
            string str3;
            str3 = String.Concat(str1, str2);
            Console.Write("\n-----------------------------------\n");
            Console.WriteLine("Noi 2 chuoi A va B");
            Console.WriteLine("Chuoi a va b sau khi noi: {0}\n",str3);
            Console.Write("-----------------------------------\n");
            while (str3.IndexOf("a") != -1)
            {
                str3 = str3.Replace("a", "b");
            }
            Console.WriteLine("Chuoi a va b sau khi thay the ki tu: {0}\n", str3);
            //Chuyen thanh chu hoa
            Console.Write("-----------------------------------\n");
            Console.WriteLine("Chuyen thanh chu Hoa ");
            str1 = str1.ToUpper();
            str2 = str2.ToUpper();
            Console.Write("Chuoi A vua nhap: {0}\n", str1);
            Console.Write("Chuoi B vua nhap: {0}\n", str2);


        
            Console.ReadLine();
        }
    }
}
