using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham.Validator
{
    class ProductValid
    {
        public static string StringInputValid(string text, string error)
        {
            string input;
            Console.WriteLine(text);
            do
            {
                input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input;
                }

                Console.WriteLine($"{error}");

            } while (true);
        }

        public static float FloatInputValid(string text, string error)
        {
            float value;
            Console.WriteLine(text);
            do
            {
                string input = Console.ReadLine();

               if(float.TryParse(input, out value))
                {
                    return value;
                }
                Console.WriteLine($"{error}: ");

            } while (true);
        }

        public static int IntInputValid(string text, string error)
        {
            int value;
            Console.WriteLine(text);
            do
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out value))
                {
                    return value;
                }
                Console.WriteLine($"{error}");
            } while (true);
        }
    }
}
