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
      Console.WriteLine("Кол-во строк: ");
      int M=Int32.Parse(Console.ReadLine());
      Console.WriteLine("Кол-во столбцов: ");
      int N=Int32.Parse(Console.ReadLine());
      double[,] matrix = new double[M,N];
      PrintArray(matrix);
      FillArray(matrix);
      Console.WriteLine();
      PrintArray(matrix);
      
      void FillArray(double[,] arr)
      {
        Random rand = new Random();
        for (int i = 0; i < arr.GetLength(0); i++)
        {
          for (int j = 0; j < arr.GetLength(1); j++)
          {
            arr[i, j] = rand.NextDouble()*100;
          }
          Console.WriteLine();
        }
      }

      void PrintArray(double[,] matr)
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
    }
  }
}