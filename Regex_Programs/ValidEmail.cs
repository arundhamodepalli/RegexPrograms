using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_Programs
{
        public class ValidEmail
        {
            public static string Regix_Rule = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
            public static int Valid_Email()
            {
                string Email;
                Console.WriteLine("Enter your Email: ");
                Email = Convert.ToString(Console.ReadLine());

                if (char.IsUpper(Email[0]) && Email.Length >= 2)
                {
                    Console.WriteLine("Valid Email!");
                }
                else
                {
                    Console.WriteLine("Invalid Email. Please enter a  Email has 3 mandatory parts (abc, bl\r\n& co) and 2 optional (xyz & in) with\r\nprecise @ and . positions.");
                }

                //Console.ReadLine();
                return default;
            }
        }
}

