using Shouldly;

namespace cs_functional_exercises.Test
{
    public class Exercise2Test
    {
        [Test]
        public void GetCoolPeople_ShouldReturnListOfEmails() 
        {
            List<string> output = new List<string> {"rich.neat@boardgamer.com", "poppy.mcdonnell@irishdancer.com",
            "neil.hughes@walkingoncustard.com", "alice.yang@midfielder.com", "pippa.austin@musician.com"};

            List<string> result = Exercises002.GetCoolPeople();

            result.ShouldBe(output);


        }
        //[Test]
        //public void GetUsernames_ShouldReturnUsernames()
        //{
        //    List<string> input = new List<string> {"rich.neat@boardgamer.com", "poppy.mcdonnell@irishdancer.com",
        //    "neil.hughes@walkingoncustard.com", "alice.yang@midfielder.com", "pippa.austin@musician.com"};

        //    List<string> output = new List<string> { "rich.neat", "poppy.mcdonnell", "neil.hughes", "alice.yang", "pippa.austin" };

        //}

    }
}
