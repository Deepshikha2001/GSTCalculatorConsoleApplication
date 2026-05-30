using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTCalculatorConsoleApplication
{
    internal class GstCalculator
    {
       public static void Calculate()
        {
            Console.WriteLine("===== GST Calculator =====");

            Console.Write("Enter Amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\nSelect GST Type:");
            Console.WriteLine("1. CGST + SGST");
            Console.WriteLine("2. IGST");

            Console.Write("Enter Choice-1 or 2 : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter GST Percentage: ");
            decimal gstPercentage = Convert.ToDecimal(Console.ReadLine());

            decimal gstAmount = amount * gstPercentage / 100;
            decimal grandTotal = amount + gstAmount;

            Console.WriteLine("\n==========================");
            Console.WriteLine($"Amount      : {amount:F2}");
            Console.WriteLine($"GST Rate    : {gstPercentage}%");

            if (choice == 1)
            {
                decimal cgst = Math.Round(gstAmount / 2, 2);
                decimal sgst = Math.Round(gstAmount / 2, 2);

                Console.WriteLine($"CGST ({gstPercentage / 2}%) : {cgst:F2}");
                Console.WriteLine($"SGST ({gstPercentage / 2}%) : {sgst:F2}");
            }
            else if (choice == 2)
            {
                Console.WriteLine($"IGST ({gstPercentage}%) : {gstAmount:F2}");
            }
            else
            {
                Console.WriteLine("Invalid GST Type Selected.");
                return;
            }

            Console.WriteLine($"Total GST   : {gstAmount:F2}");
            Console.WriteLine($"Grand Total : {grandTotal:F2}");
            Console.WriteLine("==========================");
        }
    }
}
