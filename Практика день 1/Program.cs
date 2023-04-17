using System;

class Program
{
    static void Main(string[] args)
    {
        double a = 20; // замените на нужное значение
        double b = 0; // замените на нужное значение

        double averageArithmetic = (a + b) / 2;
        double averageGeometric = Math.Sqrt(a * b);

        Console.WriteLine("Среднее арифметическое: " + averageArithmetic);
        Console.WriteLine("Среднее геометрическое: " + averageGeometric);
    }
}