// Math.Round();-округление
Console.Clear();
Console.WriteLine("Введите кол-во строк: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int n=Convert.ToInt32(Console.ReadLine());
double [,] arr=new double [m,n];
PrintArray(arr);
FillArray(arr);
Console.WriteLine();
PrintArray(arr);
void PrintArray(double[,] matr)
{
    for (int i=0;i<matr.GetLength(0);i++)
    {
        for (int j=0;j<matr.GetLength(1);j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
    Console.WriteLine();
    }
}
void FillArray(double[,] matr)
{
    for (int i=0;i<matr.GetLength(0);i++)
    {
        for (int j=0;j<matr.GetLength(1);j++)
        {
            matr[i,j]=new Random().NextDouble();
        }
    }
}