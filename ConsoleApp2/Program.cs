/*
 * Напишите программу с бесконечным циклом, как в предыдущем юните, которая будет:
-ожидать ввода числа с клавиатуры (используйте Console.ReadLine());
-добавлять число в список, хранящийся в памяти;
-выводить после добавления следующую информацию: 
-количество чисел в списке,
-сумму всех чисел списка,
-наибольшее и наименьшее числа, 
-а также их среднее значение.
*/


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Enter numbers: ");
            while (true)
            {

                string input = Console.ReadLine();
                var isInteger = Int32.TryParse(input, out int inputNum);

                if (!isInteger)
                {
                    Console.WriteLine("введено не число");
                }
                else
                {
                    list.Add(inputNum);

                    // выводим все критерии
                    Console.WriteLine("Число " + input + " добавлено в список.");
                    Console.WriteLine($"Всего в списке  {list.Count} чисел");
                    Console.WriteLine($"Сумма:  {list.Sum()}");
                    Console.WriteLine($"Наибольшее:  {list.Max()}");
                    Console.WriteLine($"Наименьшее:  {list.Min()}");
                    Console.WriteLine($"Среднее:  {list.Average()}");
                }
            }
            Console.ReadKey();
        }
    }
}