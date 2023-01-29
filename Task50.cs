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
      int[,] matrix = new int[3, 4];
      Console.WriteLine("Введите число: ");
      int number=Int32.Parse(Console.ReadLine());
      PrintArray(matrix);
      FillArray(matrix);
      Console.WriteLine();
      PrintArray(matrix);
      CheckArray(matrix);
      void CheckArray(int[,] arr)
      {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
          for (int j = 0; j < arr.GetLength(1); j++)
          {
            if (arr[i,j]==number)
            {
              Console.WriteLine($"Такой элемент есть и он нахолится на такой({arr[i,j]}) позиции");
              break;
            }
            else
            {
              Console.WriteLine("Такого числа нет");
            }
          }
          Console.WriteLine();
        }
      }

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
      
      void FillArray(int[,] arr)
      {
        Random rand = new Random();
        for (int i = 0; i < arr.GetLength(0); i++)
        {
          for (int j = 0; j < arr.GetLength(1); j++)
          {
            arr[i, j] = rand.Next(-150,151);
          }
          Console.WriteLine();
        }
      }
    }
  }
}