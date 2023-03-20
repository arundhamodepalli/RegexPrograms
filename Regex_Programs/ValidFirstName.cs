using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_Programs
{
        public class ValidFirstName
        {
            public static string Regix_Rule = "^[A-Z a-z]{3}$";
            public static int Valid_FirstName()
            {
                string FirstName;
                Console.WriteLine("Enter your FirstName: ");
                FirstName = Convert.ToString(Console.ReadLine());

                if (char.IsUpper(FirstName[0]) && FirstName.Length >= 3)
                {
                    Console.WriteLine("Valid firstName!");
                }
                else
                {
                    Console.WriteLine("Invalid FirstName. Please enter a first name that starts with a capital letter and has at least 3 characters.");
                }

                //Console.ReadLine();
                return default;
            }
        }
}
