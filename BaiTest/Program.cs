using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BaiTest
{
    internal class Program
    {
        static void nhap(int[] A, int N)
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write("a[" + i + "]=");
                A[i] = int.Parse(Console.ReadLine());
            }
        }
        static void xuat(int[] A, int N)
        {
            Console.Write("Day so ban nhap:");
            
            Console.WriteLine(" ");
            for (int i = 0; i < N; i++)
            {
                Console.Write("+--");

            }
            Console.Write("+");
            Console.WriteLine(" ");
            for (int i = 0; i < N; i++)
            {
                Console.Write("|" + A[i] + "|");

            }
            Console.WriteLine(" ");
            for (int i = 0; i < N; i++)
            {
                Console.Write("+--");

            }
            Console.Write("+");
            Console.WriteLine(" ");
            
        }
        static void sapxeptang(int[] A, int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (A[i] > A[j])
                    {
                        
                        int temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine(" ");
        }
        static void sapxepgiam(int[] A, int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (A[i] < A[j])
                    {

                        int temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine(" ");
        }
        static void demosapxeptang(int[] A, int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (A[i] > A[j])
                    {

                        int temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                        
                    }
                    for (int z = 0; z < N; z++)
                    {
                        Console.Write(A[z] + " ");
                    }
                    Console.WriteLine(" ");
                    Thread.Sleep(500);

                }
            }

            xuat(A, N);
        }
        static void menu()
        {
            Console.WriteLine("***************MAIN MENU**********");
            Console.WriteLine("1.NHAP LAI");
            Console.WriteLine("2.SAP XEP TANG");
            Console.WriteLine("3.SAP XEP GIAM");
            Console.WriteLine("4.IN DAY SO");
            Console.WriteLine("5.DEMO SAP XEP TANG");
            Console.WriteLine("6.THOAT");
        }
        static void nhapso()
        {
            do
            {
                Console.Write("NHAP LUA CHON:");

                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        nhap(A, N);
                        break;

                    case 2:
                        sapxeptang(A, N);
                        break;

                    case 3:
                        sapxepgiam(A, N);
                        break;

                    case 4:
                        xuat(A, N);
                        break;
                    case 5:
                        demosapxeptang(A, N);
                        break;
                    case 6:

                        break;
                    default:
                        Console.WriteLine("Nhap lai ban oi");
                        break;

                }

            } while (chon != 6);
        }
        static void Main(string[] args)
        {
            int chon;
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[100];
            nhap(A, N);
            menu();
            nhapso();
            
            Console.ReadLine();
        }

    }
}
