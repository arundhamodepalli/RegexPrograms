using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_Programs
{
    public class MobileNumberFormat
    {
        public static string Regix_Rule = "^[1-90-9][][1-90-9]{10}$";
        public static int MobileNumber_Format()
        {
            Console.WriteLine("Enter a mobile number (in the format 91 1234567890):");
            string mobileNumber = Console.ReadLine();

            if (IsValidMobileNumber(mobileNumber))
            {
                Console.WriteLine("The mobile number is valid.");
            }
            else
            {
                Console.WriteLine("The mobile number is not valid.");
            }

            //Console.ReadLine();
            return default;
        }

        private static bool IsValidMobileNumber(string? mobileNumber)
        {
            throw new NotImplementedException();
        }
    }
}

