namespace Agregate_Арифметика
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int result = numbers.Aggregate((x, y) => x - y);

            // вычислит 1-2-3-4-5 = -13
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}