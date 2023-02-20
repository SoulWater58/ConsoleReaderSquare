using System;

namespace Lab8ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());
            int squareNum = num * num;
            int stepen3Num = squareNum * num;
            Console.Write($"Число {num} в квадрате = {squareNum}, в третьей степени = {stepen3Num}.");
        }
    }
}
