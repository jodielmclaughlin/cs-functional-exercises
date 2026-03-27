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

        public static Action<List<string>> PrintCoolPeople = people => people.ForEach(n => Console.WriteLine(n));

        public static Action<List<int>> SquaredNums = (nums) =>
        {
            for (int i = 0; i < nums.Count; i++)
            {
                nums[i] *= nums[i];
            }
        };

        public static Action<List<int>> PrintNums = nums => nums.ForEach(n => Console.WriteLine(n));

        public static Action<List<int>> PrintSquaredNums = nums => { SquaredNums(nums); PrintNums(nums); };

        public static Dictionary<string, List<string>> FilterEmails(List<string> emails)
        {
            Dictionary<string, List<string>> emailAddresses = new Dictionary<string, List<string>>();
            Predicate<string> coUkDomain = emails => emails.Contains(".co.uk");
            Predicate<string> comDomain = email => email.Contains("com");



        }
    }
}
