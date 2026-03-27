using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace cs_functional_exercises
{
    public class Exercise001
    {
        public static Func<int, int> SquareIt = num => num * num;
        
        public static Func<int, int> AddTen = num => num + 10;
        
        public static Predicate<string> GrammarCheck = word => word.StartsWith("A") && word.EndsWith("!");

        public static Func<string, string, int> SumIndices = (wordA, wordB) => wordA.IndexOf("a") + wordB.IndexOf("e");

        public static string CheckValidEmail(string email)
        {
            Predicate<string> whereFrom = email => email.Contains("@northcoders.co.uk");
           
            string username = email.Split('@')[0];
            Predicate<string> usernameCheck = username => username.Length >= 5;
            if(whereFrom(email) && usernameCheck(username))
            {
                Console.WriteLine("Email domain and user valid, please continue");
                return "Email domain and user valid, please continue";
            }
            Console.WriteLine("Email domain and user name invalid, please check your input");
            return "Email domain and user name invalid, please check your input";
        }

    }
}
