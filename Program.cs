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
      Console.WriteLine("Введите кол-во чисел: ");
      int N = Convert.ToInt32(Console.ReadLine());
      int[] arr=new int[N];
      int kol = 0;
      Summa_number(arr);
      void Summa_number(int[] matr)
      {
        for (int i = 0; i < arr.Length; i++)
        {
          Console.WriteLine($"Введите {i+1} число: ");
          matr[i] = Convert.ToInt32(Console.ReadLine());
          if (matr[i] > 0)
          {
            kol++;
          }
          else
          {
            kol += 0;
          }
        }

        Console.WriteLine($"Кол-во полож чисел равно {kol}");
      }
    }
  }
}