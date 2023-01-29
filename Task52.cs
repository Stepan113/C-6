using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading;

namespace Первая_программа_на_Rider
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int sr_ar = 0;
            int kol=0;
            int[,] arr = new int [3, 4];
            PrintArray(arr);
            FillArray(arr);
            Console.WriteLine();
            PrintArray(arr);
            Summa_Array(arr);
            void PrintArray(int[,] matr)
            {
                for (int i = 0; i < matr.GetLength(0); i++)
                {
                    for (int j = 0; j < matr.GetLength(1); j++)
                    {
                        Console.Write($"{matr[i,j]} ");
                    }
                    Console.WriteLine();
                }
            }

            void FillArray(int[,] matrix)
            {
                Random rand = new Random();
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = rand.Next(-151, 150);
                    }
                }
            }

            void Summa_Array(int[,] matr)
            {
                for (int i = 0; i < matr.GetLength(1); i++)
                {
                    for (int j = 0; j < matr.GetLength(0); j++)
                    {
                        sr_ar += matr[j, i];
                        kol++;
                    }
                    Console.WriteLine($"Среднее арифметическое {i+1} столбца равно {sr_ar/kol}");
                    sr_ar = 0;
                    kol=0;
                }
            }
        }
    }
}