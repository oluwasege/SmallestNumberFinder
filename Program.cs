using System;
using System.Linq;

namespace SmallestNumberFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! ");
            Console.WriteLine("This is a program to find the smallest of three numbers you Enter");
            Console.WriteLine("Please Enter the first number");
            int fnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the second number");
            int snumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the third number");
            int tnumber = int.Parse(Console.ReadLine());
            int[] number = {fnumber,snumber,tnumber };
            int min = number.Min();
            Console.WriteLine($"The minimum smallest number is {min}");

        }
    }
}
