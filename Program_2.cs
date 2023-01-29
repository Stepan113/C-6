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
      Console.WriteLine("Введите k1: ");
      double k1=Double.Parse(Console.ReadLine());
      Console.WriteLine("Введите b1: ");
      double b1=Double.Parse(Console.ReadLine());
      Console.WriteLine("Введите k2: ");
      double k2=Double.Parse(Console.ReadLine());
      Console.WriteLine("Введите b2: ");
      double b2=Double.Parse(Console.ReadLine());
      if (k1==k2)
      {
        Console.WriteLine("Прямые параллельные");
      }
      else if (k1==k2 && b1==b2)
      {
        Console.WriteLine("Прямые совпадают");
      }
      else
      {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения ({x}{y})");
      }
    }
  }
}