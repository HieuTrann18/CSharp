using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap1_2.Validator
{
    class ProductValid
    {

        public static string ValidateStringInput(string message)
        {
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    return input;
                }

                Console.WriteLine("Khong hop le vui long nhap lai: ");
            } while (true);
        }

        public static float ValidateFloatInput(string message)
        {
            float value;
            do
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (float.TryParse(input, out value) && value >= 0)
                {
                    return value;
                }

                Console.WriteLine("Khong hop le vui long nhap lai: ");
            } while (true);
        }
    }
}
