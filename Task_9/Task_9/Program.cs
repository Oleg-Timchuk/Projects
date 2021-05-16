using System;
using System.Reflection;
using System.Diagnostics;
using System.IO;

namespace Task_9
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.InputEncoding = System.Text.Encoding.Unicode;

                Console.WriteLine("Введите N = ");
                int N = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите M = ");
                int M = Convert.ToInt32(Console.ReadLine());

                int[,] massiv = new int[N, M];
                Work.EnterN(N);
                Work.EnterM(M);

                massiv = Work.FillArray(N, M);
                Work.PrintMassiv(massiv);
                Console.WriteLine("Введите ключ:");
                int a = Convert.ToInt32(Console.ReadLine());

                Work.Search(a, massiv);
                Work.Product(massiv);

                Work.IsEqual del;
                del = Work.ConditionCheck;
                Work.MyCalculator(massiv, del); // x > 17
                Work.MyCalculator(massiv, b => b % 13 == 0);
            }
            catch                                    
            {
                Console.WriteLine("Ошибка");
            }
        }

        private static class Work
        {

            public delegate bool IsEqual(int x);

            public static bool ConditionCheck(int x)
            {
                if (x > 17)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static void MyCalculator(int[,] massiv, IsEqual func)
            {
                int count = 0;
                foreach(int elem in massiv)
                {
                    if (func(elem))
                        count += 1;
                }
                Console.WriteLine("Кількість чисел, які задоволняють умові = " + count);
               
            }
            private static int N { get; set; }

            public static int n
            {
                get
                {
                    return N;
                }
                set
                {
                    N = value;
                }
            }

            private static int M { get; set; }

            public static int m
            {
                get
                {
                    return m;
                }
                set
                {
                    m = value;
                }
            }

            public static void EnterN(int a)
            {
                N = a;
            }

            public static void EnterM(int a)
            {
                M = a;
            }

            public static int[,] FillArray(int N, int M)
            {
                int[,] massiv = new int[N, M];

                Random rand = new Random();

                for (int i = 0; i < N; i++)
                    for (int j = 0; j < M; j++)
                    {
                        massiv[i, j] = rand.Next(1, 40);
                    }

                return massiv;
            }

            public static void Search(int a, int[,] massiv)
            {
                int lenght = 0;

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        if (a == massiv[i, j])
                        {
                            Console.WriteLine($"Елемент {massiv[i, j]} на позиции[{i},{j}]");
                            lenght++;
                        }
                    }
                }
                if (lenght == 0)
                {
                    Console.WriteLine("Нету такого елемента");
                }
            }

            public static void PrintMassiv(int[,] massiv)
            {
                Console.WriteLine("Mассив:");
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        Console.Write(massiv[i, j]);
                        if (massiv[i, j] < 10)
                        {
                            Console.Write("   ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                    Console.Write("\n");
                }
            }

            public static void Product(int[,] massiv)
            {
                for (int i = 0; i < N; i++)
                {
                    int min = massiv[i, 0];
                    int max = massiv[i, 0];
                    for (int j = 0; j < M; j++)
                    {
                        if (massiv[i, j] < min)
                        {
                            min = massiv[i, j];
                        }
                        else if (massiv[i, j] > max)
                        {
                            max = massiv[i, j];
                        }
                    }

                    Console.WriteLine($"Произведение для {i + 1} рядка = {min * max}");
                }
            }          
        }
    }
}