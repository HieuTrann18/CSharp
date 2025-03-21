using ProductManagementAdvance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementAdvance.Application.Validation
{
    static class ProductValidator
    {
        public static string GetValidString(string prompt, string message)
        {
            Console.WriteLine(prompt);
            do
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input;
                }
                Console.WriteLine($"{message}. Please re-enter!");
            } while (true);
        }

        public static int GetValidInt(string prompt, string message)
        {
            Console.WriteLine(prompt);
            do
            {
                if(int.TryParse(Console.ReadLine(), out int value))
                {
                    if(value > 0)
                    {
                        return value;
                    }
                    Console.WriteLine($"{message} must be greater than zero");   
                }
            } while (true);
        }

        public static double GetValidDouble(string prompt, string message)
        {
            Console.WriteLine(prompt);
            do
            {
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    if (value > 0)
                    {
                        return value;
                    }
                    Console.WriteLine($"{message} must be greater than zero");
                }
            } while (true);
        }

        
    }
}
