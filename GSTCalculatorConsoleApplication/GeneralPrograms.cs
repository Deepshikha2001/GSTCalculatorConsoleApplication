using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTCalculatorConsoleApplication
{
    internal class GeneralPrograms
    {

        //C# Program to swap two numbers
        public static void Swapping()
        {
            int a, b, temp;
            Console.WriteLine("===== Swapp of a Number =====");
            Console.Write("Enter First Number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            b = Convert.ToInt32(Console.ReadLine());

            // Swapping Logic
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"After Swapping: First Number = {a}, Second Number = {b}");

        }

        //C# Program to Check Whether a Given Number is Even or Odd
        public static void EvenOdd()
        {
            int number;
            Console.WriteLine("===== Even/Odd =====");
            Console.Write("Enter a Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an Even Number.");
            }
            else
            {
                Console.WriteLine($"{number} is an Odd Number.");
            }
        }

        //C# Program to Print Odd Numbers in a Given Range
        public static void OddNoInRange()
        {
            int start, end;
            Console.WriteLine("===== Odd Numbers in a Range =====");
            Console.Write("Enter Starting Number: ");
            start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Ending Number: ");
            end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Odd Numbers between {start} and {end}:");
            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + ", ");
                }
            }
        }

        //C# Program to Check Whether a Number is Positive or Not
        public static void PositiveOrNot()
        {
            double number;
            Console.WriteLine("===== Positive number program =====");
            Console.Write("Enter a Number: ");
            number = Convert.ToDouble(Console.ReadLine());
            if (number >= 0)
            {
                Console.WriteLine($"Given Number {number}is Positive ");

            }
            else
            {
                Console.WriteLine($"Given Number {number}is Negative ");

            }


        }
        //C# Program to Find the Largest of Two Numbers
        public static void LargestNumber()
        {
            int num1, num2;
            Console.WriteLine("===== Largest of Two Numbers =====");
            Console.Write("Enter First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine($"Largest Number is: {num1}");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Both numbers are equal.");
            }
            else
            {
                Console.WriteLine($"Largest Number is: {num2}");
            }
        }
        //C# Program to Check if a Number is Divisible by 2
        public static void DivisibleByTwo()
        {
            int number;
            Console.WriteLine("===== Divisible by 2 =====");
            Console.Write("Enter a Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is Divisible by 2.");
            }
            else
            {
                Console.WriteLine($"{number} is Not Divisible by 2.");
            }
        }
        // C# Program to Find the Sum of All the Multiples of 3 and 5
        public static void SumOfMultiples()
        {
            int limit, sum = 0;
            Console.WriteLine("===== Sum of Multiples of 3 and 5 =====");
            Console.Write("Enter the Limit: ");
            limit = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < limit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Sum of all multiples of 3 and 5 below {limit} is: {sum}");
        }

        //C# Program to Print All the Multiples of 17 which are Less than 100
        public static void PrintMultiplesOf17()
        {
            Console.WriteLine("===== Multiples of 17 =====");
            for (int i = 1; i < 100; i++)
            {
                if (i % 17 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        //C# Program to Find Sum of Digits of a Number
        public static void SumOfDigits()
        {
            int number, sum = 0;
            Console.WriteLine("===== Sum of Digits =====");
            Console.Write("Enter a Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                sum += number % 10; // Add the last digit to sum
                number /= 10; // or number = number/10 Remove the last digit
            }
            Console.WriteLine($"Sum of digits is: {sum}");

        }

        //C# Program to Find Sum of Digits of a Number using Recursion
        //program first for sum of digits using recursion 
        public static int SumOfDigitsRecursion(int number)
        {
            if (number == 0)
                return 0;
            else
                return (number % 10) + SumOfDigitsRecursion(number / 10);
        }
        //program  for factorial using recursion
       

        public static int FactorialRecursion(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * FactorialRecursion(n - 1);
        }
        //program for fibonacci series using recursion
        //fibonacci series is a series of numbers where each number is the sum of the two preceding ones,
        //usually starting with 0 and 1. The sequence goes: 0, 1, 1, 2, 3, 5, 8, 13, and so on.
        //formula for fibonacci series is F(n) = F(n-1) + F(n-2) with base cases F(0) = 0 and F(1) = 1.
        //program for fibonacci series using recursion
        public static int FibonacciRecursion(int n)
        {
            if (n <= 1)
                return n;
            else
                return FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
        }

        //fibonacci pattern
        public static void PrintFibonacciPattern(int terms)
        {
            Console.WriteLine("===== Fibonacci Pattern =====");
            for (int i = 0; i < terms; i++)
            {
                Console.Write(FibonacciRecursion(i) + " ");
            }
            Console.WriteLine();
        }


    }
}