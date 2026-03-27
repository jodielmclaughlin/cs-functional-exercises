using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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


            
    }
}
