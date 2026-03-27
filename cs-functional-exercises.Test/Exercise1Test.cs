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
        [Test]
        public void AddTen_ShouldReturnNumbersPlus10()
        {
            List<int> numbers = new List<int> { 4, 15, 55, 78, 12 };
            List<int> expected = new List<int> { 14, 25, 65, 88, 22 };

            List<int> results = numbers.Select(n => Exercise001.AddTen(n)).ToList();

            results.ShouldBe(expected);
        }
        [Test]
        public void GrammarCheck_ShouldCheckWordsStartWithAAndEndWithExclamationMark()
        {
            List<string> words = new List<string> { "Amazing!", "apple!", "Awesome!", "Artichoke" };
            List<bool> expected = new List<bool> { true,  false, true, false };

            List<bool> results = words.Select(n => Exercise001.GrammarCheck(n)).ToList();

            results.ShouldBe(expected);
        }
        [Test]
        public void SumIndices_ShouldAddIndexsOfStringCharsToReturnInt()
        {
            string wordA = "start";
            string wordB = "pale";

            int expected = 5;
            int result = Exercise001.SumIndices(wordA, wordB);

            result.ShouldBe(expected);
        }
    }
}