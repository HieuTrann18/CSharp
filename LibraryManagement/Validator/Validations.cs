using LibraryManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Validator
{
    class Validations
    {   


        public string StringValid(string input)
        {
            while (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input! Please enter again");
                input = Console.ReadLine();
            }
            return input;
        }
    }
}
