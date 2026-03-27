using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_functional_exercises
{
    public class Exercises002
    {
        public static Func<List<string>> GetCoolPeople = () => new List<string> {"rich.neat@boardgamer.com", "poppy.mcdonnell@irishdancer.com", 
            "neil.hughes@walkingoncustard.com", "alice.yang@midfielder.com", "pippa.austin@musician.com"};

        public static Action<string> GetUsernames = users => Console.WriteLine(users.Split("@")[0]);
       
    }
}
