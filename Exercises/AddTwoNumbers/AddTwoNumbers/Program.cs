//Write a C# Sharp program to print the sum of two numbers.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, total;
            
            Console.WriteLine("Sum of two numbers");
            Console.Write("Number 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Number 2: ");
            num2 = int.Parse(Console.ReadLine());
            total = num1 + num2;
            Console.WriteLine("Total of Number 1 and Number 2 is " + total);
            Console.ReadLine();
        }
    }
}
