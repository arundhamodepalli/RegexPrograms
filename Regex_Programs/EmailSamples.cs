using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_Programs
{
    public class EmailSamples
    {
        public static string Regix_Rule = "^[a-zA-Z][-][1-90-9][@][a-zA-Z][.][a-zA-Z]$";
        public static int Email_Samples()
        {
            string Email;
            Console.WriteLine("Enter your Email: ");
            Email = Convert.ToString(Console.ReadLine());

            if (char.IsUpper(Email[0]) && Email.Length >= 0)
            {
                Console.WriteLine("Valid Email!");
            }
            else
            {
                Console.WriteLine("Invalid Email!.Should clear all\r\nemail samples\r\nprovided separately");
            }

            //Console.ReadLine();
            return default;
        }
    }
}

