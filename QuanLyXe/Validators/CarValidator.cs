using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyXe.Validators
{
    class CarValidator
    {
        public static string StandardString(string prompt, string error)
        {
           
            Console.WriteLine(prompt);
            do
            {
                    string input = Console.ReadLine() ?? "";
                    if (!string.IsNullOrWhiteSpace(input))
                    {
                        return input;
                    }
                    Console.WriteLine(error);
            } while (true);
        }

        public static float StandardFloatInput(string prompt, string error)
        {
            Console.WriteLine(prompt);
            do
            {
                try
                {
                    if (float.TryParse(Console.ReadLine(), out float value)) 
                    {
                        if (value <= 0)
                        {
                            Console.WriteLine("Value must be a positive integer. Please re-enter: ");
                            continue;
                        }
                        return value;
                    }

                    Console.WriteLine(error);
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Error entering real number: {ex.Message}");
                    continue;
                }
            } while (true);
        }

        public static int StandardIntInput(string prompt, string error)
        {
            Console.WriteLine(prompt);
            do
            {
                try
                {
                    if (int.TryParse(Console.ReadLine(), out int value))
                    {
                        if(value <= 0)
                        {
                            Console.WriteLine("Value must be a positive integer. Please re-enter: ");
                            continue;
                        }
                        return value;
                    }
                    Console.WriteLine(error);
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Error entering integer: {ex.Message}");
                    continue;
                }
            } while (true);
        }
    }
}
