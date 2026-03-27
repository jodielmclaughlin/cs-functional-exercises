namespace cs_functional_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 4, 15, 55, 78, 12 };
            numbers.ForEach(n => Console.WriteLine(Exercise001.AddTen(n)));

            List<string> words = new List<string> { "Amazing!", "apple!", "Awesome!", "Artichoke" };
            words.ForEach(n => Console.WriteLine(Exercise001.GrammarCheck(n)));

            string firstWord = "start";
            string secondWord = "pale";
            Console.WriteLine(Exercise001.SumIndices(firstWord, secondWord));
        }
    }
}
