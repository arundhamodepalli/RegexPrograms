using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_Programs
{
    public class PSpecialCharacter
    {
        public static string Regix_Rule = "^[A-Z a-z][A-za-z][1-90-9]{8}@$";
        public static int PSpecial_Character()
        {
            string Password;
            Console.WriteLine("Enter your Password: ");
            Password = Convert.ToString(Console.ReadLine());

            if (char.IsUpper(Password[0]) && Password.Length >= 8)
            {
                Console.WriteLine("Valid Password!");
            }
            else
            {
                Console.WriteLine("Invalid Password. Please enter a password with 8 characters have atleast one upper case and one numeric and special character .");
            }

            //Console.ReadLine();
            return default;
        }
    }
}
