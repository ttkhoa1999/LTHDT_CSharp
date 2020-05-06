using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1710197_TranThanhKhoa_Stack
{
    class Program
    {
        public class Stack
        {
            const int MAX = 100;
            int top;
            int[] mang;
            public Stack()
            {
                mang = new int[MAX];
                top = 0;
            }
            public Stack(int N)
            {
                mang = new int[MAX];
                top = 0;
            }
            public void Init()
            {
                top = 0;
            }
            public bool isEmpty()
            {
                if (top == 0)
                    return true;
                else
                    return false;
            }
            public bool isFull()
            {
                if (top == MAX)
                    return true;
                else
                    return false;
            }
            public void push(int T)
            {
                if (!isFull())
                {
                    mang[top++] = T;
                }
                else
                    Console.WriteLine("Stack da full! ");
            }
            public int pop()
            {
                if (!isEmpty())
                    return mang[--top];
                else
                    return -int.MaxValue;
            }
            public void Show()
            {
                string str = " ";
                for (int i = 0; i < top; i++)
                {
                    str += mang[i] + " ";
                }
                    Console.WriteLine(" {0} ", str);
            }
            public static Stack ChuyenDoi(int x, int n)
            {
                Stack a = new Stack();
                while (x > 0)
                {
                    a.push((int)(x % n));
                    x /= n;
                }
                return a;
            }
            public static void Xuat(Stack a)
            {
                while (!a.isEmpty())
                {
                    int m = (int)a.pop();
                    switch (m)
                    {
                        case 10:
                            Console.Write("A");
                            break;
                        case 11:
                            Console.Write("B");
                            break;
                        case 12:
                            Console.Write("C");
                            break;
                        case 13:
                            Console.Write("D");
                            break;
                        case 14:
                            Console.Write("E");
                            break;
                        case 15:
                            Console.Write("F");
                            break;
                        default:
                            Console.Write("{0}", m);
                            break;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Stack s1 = new Stack();
            Stack s2 = new Stack();
            int x;
            s1.push(1);
            s1.push(2);
            s1.push(3);
            s1.push(4);
            s1.push(5);
            s1.push(6);
            Console.Write("Cac phan tu da duoc day vao stack 1: ");
            s1.Show();
            Console.Write("Cac phan tu sau khi lay phan tu o dinh ra: ");
            s1.pop();
            s1.Show();
            Console.WriteLine("\n========= Kiem tra =========");
            if (s1.isFull())
            {
                Console.WriteLine("Stack 1 da full! ");
            }
            else
            {
                Console.WriteLine("Stack 1 chua full! ");
            }
          
            Console.Write("Nhap so thap phan n : ");
            x = Int32.Parse(Console.ReadLine());
            Console.Write("So thap phan {0} khi chuyen sang he 2: ", x);
            s2 = Stack.ChuyenDoi(x, 2);
            Stack.Xuat(s2);
            Console.WriteLine();
            Console.Write("So thap phan {0} khi chuyen sang he 16: ", x);
            s1 = Stack.ChuyenDoi(x, 16);
            Stack.Xuat(s1);
            Console.ReadLine();
        }
    }
}
