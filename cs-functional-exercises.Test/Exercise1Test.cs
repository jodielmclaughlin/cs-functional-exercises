using Shouldly;
namespace cs_functional_exercises.Test
{
    public class Tests
    {
       
        [Test]
        public void SquareIt_ShouldReturnInputSquared()
        {
            int num = 3;
            int squared = 9;

            int result = Exercise001.SquareIt(num);
            result.ShouldBe(squared);
        }
    }
}