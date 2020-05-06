using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matran
{
    class Program
    {
        public class Matran
        {
            int h;
            int c;
            double[,] M;
            public Matran()
            {

            }
            public Matran(int h, int c)
            {
                this.h = h;
                this.c = c;
                M = new double[h, c];
            }
            public Matran(int num)
            {
                h = num;
                c = num;
                M = new double[h, c];
            }
            public void NhapMT()
            {
                int i, j;
                double temp = 0;
                bool kiemtra = false;
                do
                {
                    Console.Write("Nhap so hang cua ma tran: ");
                    kiemtra = Int32.TryParse(Console.ReadLine(), out h);
                } while (!kiemtra);

                do
                {
                    Console.Write("\nNhap so cot cua ma tran: ");
                    kiemtra = Int32.TryParse(Console.ReadLine(), out c);
                } while (!kiemtra);
                M = new double[h, c];
                for (i = 0; i < h; i++)
                    for (j = 0; j < c; j++)
                    {
                        do
                        {
                            Console.Write("\n- Nhap phan tu thu A[" + i + "," + j + "]: ");
                            M[i, j] = int.Parse(Console.ReadLine());
                        } while (!kiemtra);
                    }
            }
            public void XuatMT()
            {
                Console.WriteLine("==================== Ma tran ========================= \n");
                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        Console.Write("\t" + this.M[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            public static Matran operator +(Matran a, Matran b)
            {
                Matran m;
                int hangC = a.h;
                int cotC = a.c;
                m = new Matran(hangC, cotC);
                if (a.h == b.h && a.c == b.c)
                {
                    for (int i = 0; i < hangC; i++)
                    {
                        for (int j = 0; j < cotC; j++)
                        {
                            m.M[i, j] = a.M[i, j] + b.M[i, j];
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\n\t Khong cong duoc 2 ma tran!!! \n");
                }
                return m;
            }
            public static Matran operator -(Matran a, Matran b)
            {
                Matran m;
                int hangC = a.h;
                int cotC = a.c;
                m = new Matran(hangC, cotC);
                if (a.h == b.h && a.c == b.c)
                {
                    for (int i = 0; i < hangC; i++)
                    {
                        for (int j = 0; j < cotC; j++)
                        {
                            m.M[i, j] = a.M[i, j] - b.M[i, j];
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\n\t Khong tru duoc 2 ma tran!!! \n");
                }
                return m;
            }
            public static Matran operator *(Matran a, Matran b)
            {
                Matran m;
                int hangC = a.h;
                int cotC = a.c;
                m = new Matran(hangC, cotC);
                if (a.c != b.h)
                {
                    Console.WriteLine("\n\t Khong nhan duoc 2 ma tran!!! \n");
                }
                else
                {
                    for (int i = 0; i < hangC; i++)
                    {
                        for (int j = 0; j < cotC; j++)
                        {
                            m.M[i, j] = 0;
                            for (int k = 0; k < b.h; k++)
                            {
                                m.M[i, j] += a.M[i, k] * b.M[k, j];
                            }
                        }
                    }
                }
                return m;
            }
            public Matran chuyenvi(Matran a)
            {
                Matran m;
                int hangC = a.h;
                int cotC = a.c;
                m = new Matran(hangC, cotC);
                for (int i = 0; i < hangC; i++)
                {
                    for (int j = 0; j < cotC; j++)
                    {
                        m.M[j, i] = a.M[i, j];
                    }
                }
                return m;
            }

            public static bool operator ==(Matran a, Matran b)
            {
                int flag = 1;
                if(a.h != b.h && a.c != b.c)
                {
                    Console.WriteLine("Khong the so sanh hai ma tran nay!!!");
                }
                else
                {
                    for (int i = 0; i < a.h; i++)
                    {
                        for (int j = 0; j < b.c; j++)
                        {
                           if( a.M[i, j] != b.M[i, j])
                            {
                                flag = 0;
                                break;
                            }
                        }
                    }
                }
                if (flag == 1)
                    return true;
                return false;
            }
            public static bool operator !=(Matran a, Matran b)
            {
                return !(a == b);
            }
            public double Tongduongcheochinh(Matran a)
            {
                double sum = 0;
                int kq;
                for (int i = 0; i < a.h; i++)
                {
                    for (int j = 0; j < a.c; j++)
                    {
                        if(i==j)
                        {
                            sum += a.M[i, j];
                        }
                    }
                    kq = (int)sum;
                }
                
                return sum;
            }
        }
     
        static void Main(string[] args)
        {
            Matran m = new Matran();
            m.NhapMT();
            m.XuatMT();
            Matran n = new Matran();
            n.NhapMT();
            n.XuatMT();
            Console.WriteLine("\t\tTong 2 ma tran");
            Matran tong = m + n;
            tong.XuatMT();
            Console.WriteLine("\t\tHieu 2 ma tran");
            Matran hieu = m - n;
            hieu.XuatMT();
            Console.WriteLine("\t\tTich 2 ma tran");
            Matran tich = m * n;
            tich.XuatMT();
            Console.WriteLine("Nhap ma tran moi de chuyen vi!!!!");
            Matran k = new Matran();
            k.NhapMT();
            k.XuatMT();
            Console.WriteLine("\tChuyen vi ma tran vua nhap: ");
            Matran cv = new Matran();
            k = cv.chuyenvi(k);
            k.XuatMT();
            Console.WriteLine("So sanh 2 ma tran!!!!");
            Matran a = new Matran();
            m.NhapMT();
            m.XuatMT();
            Matran b = new Matran();
            n.NhapMT();
            n.XuatMT();
            Console.WriteLine("Hai ma tran bang nhau: {0}", a == b);
            Console.WriteLine("Hai ma tran khac nhau: {0}", a != b);
            Console.WriteLine("Nhap ma tran moi de tinh Tong duong cheo chinh !!!!");
            Matran h = new Matran();
            h.NhapMT();
            h.XuatMT();
            Console.WriteLine("\tTong duong cheo chinh cua ma tran vua nhap: ");        
            Console.Write("Ket qua: {0}\n",h.Tongduongcheochinh(h));
            Console.WriteLine("\tKiem tra ma tran doi xung!!! ");
            Matran DX = new Matran();
            DX.NhapMT();
            DX.XuatMT();
            cv = cv.chuyenvi(DX);
            if(DX != cv )
            {
                Console.WriteLine("Ma Tran vua nhap khong phai ma tran vuong doi xung");
            }
            else
            {
                Console.WriteLine("Ma Tran vua nhap la ma tran vuong doi xung");
            }
            Console.ReadLine();
        }
    }
}
