namespace Общие_буквы_в_словах
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "wordLong"; 
            string word2 = "wordShort";
            Console.Write($"Слово1: {word1}, Слово2: {word2}. \nПовторяющиеся буквы: ");
            var all = word1.Intersect(word2);
            foreach (var item in all)
            {
                Console.Write(item + " "); // w o r d
            }
            
            Console.ReadKey();
        }
    }
}