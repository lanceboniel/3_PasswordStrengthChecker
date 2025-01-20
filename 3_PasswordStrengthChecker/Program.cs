using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3_PasswordStrengthChecker
{
    class Program
    {
        static void Main()
        {
           
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

           
            bool isStrong = password.Length >= 8 &&
                            Regex.IsMatch(password, @"[A-Z]") &&
                            Regex.IsMatch(password, @"[a-z]") &&
                            Regex.IsMatch(password, @"[0-9]");
                         
            Console.WriteLine(isStrong ? "Password is strong." : "Password is weak.");
            Console.ReadLine();
        }
       
    }
}

