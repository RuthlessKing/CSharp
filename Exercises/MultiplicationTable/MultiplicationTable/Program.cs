/*
 * Write a C# Sharp program that takes a number as input and print its multiplication table. Go to the editor
Test Data:
Enter the number: 5
Expected Output:
5 * 0 = 0
5 * 1 = 5
5 * 2 = 10
5 * 3 = 15
....
5 * 10 = 50
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Data:");
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            int num1 = 0 * num;
            Console.WriteLine("The table is : {0} x {1} = {2}", num, 0, num1);
            int num2 = 1 * num;
            Console.WriteLine("The table is : {0} x {1} = {2}", num, 1, num2);
            int num3 = 2 * num;
            Console.WriteLine("The table is : {0} x {1} = {2}", num, 2, num3);
            int num4 = 3 * num;
            Console.WriteLine("The table is : {0} x {1} = {2}", num, 3, num4);
            int num5 = 4 * num;
            Console.WriteLine("The table is : {0} x {1} = {2}", num, 4, num5);
            int num6 = 5 * num;
            Console.WriteLine("The table is : {0} x {1} = {2}", num, 5, num6);
            int num7 = 6 * num;
            Console.WriteLine("The table is : {0} x {1} = {2}", num, 6, num7);
            int num8 = 7 * num;
            Console.WriteLine("The table is : {0} x {1} = {2}", num, 7, num8);
            int num9 = 8 * num;
            Console.WriteLine("The table is : {0} x {1} = {2}", num, 8, num9);
            int num10 = 9 * num;
            Console.WriteLine("The table is : {0} x {1} = {2}", num, 9, num10);
            int num11 = 10 * num;
            Console.WriteLine("The table is : {0} x {1} = {2}", num, 10, num11);
            Console.ReadLine();

        }
    }
}
