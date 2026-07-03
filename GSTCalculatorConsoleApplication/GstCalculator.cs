using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTCalculatorConsoleApplication
{
    internal class GstCalculator
    {
        //public static void Calculate()
        // {
        //     Console.WriteLine("===== GST Calculator =====");

        //     Console.Write("Enter Amount: ");
        //     decimal amount = Convert.ToDecimal(Console.ReadLine());

        //     Console.WriteLine("Enter  1. for CGST + SGST or 2. for IGST :");
        //     //Console.WriteLine("1. CGST + SGST");
        //     //Console.WriteLine("2. IGST");

        //     //Console.Write("Enter Choice-1 or 2 : ");
        //     int choice = Convert.ToInt32(Console.ReadLine());

        //     Console.Write("Enter GST Percentage: ");
        //     decimal gstPercentage = Convert.ToDecimal(Console.ReadLine());

        //     decimal gstAmount = (amount * gstPercentage / 100)+100;
        //     decimal grandTotal = amount + gstAmount;

        //     Console.WriteLine("\n==========================");
        //     Console.WriteLine($"Amount      : {amount:F2}");
        //     Console.WriteLine($"GST Rate    : {gstPercentage}%");

        //     if (choice == 1)
        //     {
        //         decimal cgst = Math.Round(gstAmount / 2, 2);
        //         decimal sgst = Math.Round(gstAmount / 2, 2);

        //         Console.WriteLine($"CGST ({gstPercentage / 2}%) : {cgst:F2}");
        //         Console.WriteLine($"SGST ({gstPercentage / 2}%) : {sgst:F2}");
        //     }
        //     else if (choice == 2)
        //     {
        //         Console.WriteLine($"IGST ({gstPercentage}%) : {gstAmount:F2}");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Invalid GST Type Selected.");
        //         return;
        //     }

        //     Console.WriteLine($"Total GST   : {gstAmount:F2}");
        //     Console.WriteLine($"Grand Total : {grandTotal:F2}");
        //     Console.WriteLine("==========================");
        // }
        public static int FibonacciRecursion(int n)
        {
            if (n <= 1)
                return n;
            else
                return FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
        }


        public static void PrintFibonacciPattern(int terms)
        {
            Console.WriteLine("===== Fibonacci Pattern =====");
            for (int i = 0; i < terms; i++)
            {
                Console.Write(FibonacciRecursion(i) + " ");
            }
            Console.WriteLine();
        }

        //C# Program to Reverse a Number
        public static void ReverseNumber()
        {
            int number, reversed = 0;
            Console.WriteLine("===== Reverse a Number =====");
            Console.Write("Enter a Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                int digit = number % 10; // Get the last digit
                reversed = reversed * 10 + digit; // Append the digit to the reversed number
                number /= 10; // Remove the last digit
            }
            Console.WriteLine($"Reversed Number is: {reversed}");
        }

        //C# Program to Reverse a Number and Check if it is a Palindrome
        public static void ReverseNumberPalindrome()
        {
            int number, reversed = 0, original;
            Console.WriteLine("===== Reverse a Number and Check Palindrome =====");
            Console.Write("Enter a Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            original = number; // Store the original number for palindrome check
            while (number != 0)
            {
                int digit = number % 10; // Get the last digit
                reversed = reversed * 10 + digit; // Append the digit to the reversed number
                number /= 10; // Remove the last digit
            }
            Console.WriteLine($"Reversed Number is: {reversed}");
            if (original == reversed)
            {
                Console.WriteLine($"{original} is a Palindrome.");
            }
            else
            {
                Console.WriteLine($"{original} is not a Palindrome.");
            }
        }

        //C# Program to Find the Sum of Two Binary Numbers
        public static void SumOfBinaryNumbers()
        {
            Console.WriteLine("===== Sum of Two Binary Numbers =====");
            Console.Write("Enter First Binary Number: ");
            string binary1 = Console.ReadLine();
            Console.Write("Enter Second Binary Number: ");
            string binary2 = Console.ReadLine();
            // Convert binary strings to integers
            int num1 = Convert.ToInt32(binary1, 2);
            int num2 = Convert.ToInt32(binary2, 2);
            // Calculate the sum
            int sum = num1 + num2;
            // Convert the sum back to binary
            string binarySum = Convert.ToString(sum, 2);
            Console.WriteLine($"Sum of {binary1} and {binary2} is: {binarySum}");
        }

        //C# Program to Multiply Two Binary Numbers
        public static void MultiplyBinaryNumbers()
        {
            Console.WriteLine("===== Multiply Two Binary Numbers =====");
            Console.Write("Enter First Binary Number: ");
            string binary1 = Console.ReadLine();
            Console.Write("Enter Second Binary Number: ");
            string binary2 = Console.ReadLine();
            // Convert binary strings to integers
            int num1 = Convert.ToInt32(binary1, 2);
            int num2 = Convert.ToInt32(binary2, 2);
            // Calculate the product
            int product = num1 * num2;
            // Convert the product back to binary
            string binaryProduct = Convert.ToString(product, 2);
            Console.WriteLine($"Product of {binary1} and {binary2} is: {binaryProduct}");
        }

        //C# Program to Calculate the Sum, Multiplication, Division and Subtraction of Two Numbers
        public static void BasicArithmeticOperations()
        {
            Console.WriteLine("===== Basic Arithmetic Operations =====");
            Console.Write("Enter First Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum = num1 + num2;
            double product = num1 * num2;
            double difference = num1 - num2;
            double quotient = num2 != 0 ? num1 / num2 : double.NaN; // Handle division by zero
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Difference: {difference}");
            if (double.IsNaN(quotient))
            {
                Console.WriteLine("Quotient: Division by zero is not allowed.");
            }
            else
            {
                Console.WriteLine($"Quotient: {quotient}");
            }
        }

        //C# Program to Perform Multiplication of Exponents of Same Base
        public static void MultiplyExponents()
        {
            Console.WriteLine("===== Multiply Exponents of Same Base =====");
            Console.Write("Enter Base: ");
            double baseNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Exponent 1: ");
            double exponent1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Exponent 2: ");
            double exponent2 = Convert.ToDouble(Console.ReadLine());
            double result = Math.Pow(baseNum, exponent1) * Math.Pow(baseNum, exponent2);
            Console.WriteLine($"{baseNum}^{exponent1} * {baseNum}^{exponent2} = {result}");
        }
        //C# Program to Find the Division of Exponents of Same Base
        public static void DivideExponents()
        {
            Console.WriteLine("===== Divide Exponents of Same Base =====");
            Console.Write("Enter Base: ");
            double baseNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Exponent 1: ");
            double exponent1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Exponent 2: ");
            double exponent2 = Convert.ToDouble(Console.ReadLine());
            double result = Math.Pow(baseNum, exponent1) / Math.Pow(baseNum, exponent2);
            Console.WriteLine($"{baseNum}^{exponent1} / {baseNum}^{exponent2} = {result}");
        }
        //C# Program to Print Binary Equivalent of an Integer using Recursion
        public static void PrintBinaryEquivalent(int number)
        {
            if (number > 1)
            {
                PrintBinaryEquivalent(number / 2);
            }
            Console.Write(number % 2);
        }
        //C# Program to Print Multiplication Table
        public static void PrintMultiplicationTable(int number)
        {
            Console.WriteLine($"===== Multiplication Table for {number} =====");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }

        //C# Program to Read a Grade and Display the Equivalent Description
        public static void DisplayGradeDescription()
        {
            Console.WriteLine("===== Grade Description =====");
            Console.Write("Enter Grade (A, B, C, D, F): ");
            string grade = Console.ReadLine().ToUpper();

            switch (grade)
            {
                case "A":
                    Console.WriteLine("Excellent");
                    break;
                case "B":
                    Console.WriteLine("Good");
                    break;
                case "C":
                    Console.WriteLine("Average");
                    break;
                case "D":
                    Console.WriteLine("Below Average");
                    break;
                case "F":
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }
        }

        //C# Program to Convert Lowercase Characters by Uppercase and Vice-Versa
        public static void ConvertCase()
        {
            Console.WriteLine("===== Convert Case =====");
            Console.Write("Enter a String: ");
            string input = Console.ReadLine();
            StringBuilder converted = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsLower(c))
                {
                    converted.Append(char.ToUpper(c));
                }
                else if (char.IsUpper(c))
                {
                    converted.Append(char.ToLower(c));
                }
                else
                {
                    converted.Append(c); // Non-alphabetic characters remain unchanged
                }
            }
            Console.WriteLine($"Converted String: {converted}");

        }
        //C# Program to Accept the Height of a Person and Categorize as Taller, Dwarf & Average
        public static void CategorizeHeight()
        {
            Console.WriteLine("===== Height Categorization =====");
            Console.Write("Enter Height (in cm): ");
            double height = Convert.ToDouble(Console.ReadLine());

            if (height > 180)
            {
                Console.WriteLine("Category: Taller");
            }
            else if (height < 150)
            {
                Console.WriteLine("Category: Dwarf");
            }
            else
            {
                Console.WriteLine("Category: Average");
            }
        }
    }
}

