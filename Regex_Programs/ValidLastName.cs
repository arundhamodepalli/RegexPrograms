using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_Programs
{
    public class ValidLastName
    {
        public static string Regix_Rule = "^[A-Z a-z][A-Z a-z]{3}$";
        public static int Valid_LastName()
        {
            string LastName;
            Console.WriteLine("Enter your LastName: ");
            LastName = Convert.ToString(Console.ReadLine());

            if (char.IsUpper(LastName[0]) && LastName.Length >= 3)
            {
                Console.WriteLine("Valid LastName!");
            }
            else
            {
                Console.WriteLine("Invalid LastName. Please enter a Last name that starts with a capital letter and has at least 3 characters.");
            }

            //Console.ReadLine();
            return default;
        }
    }
}

