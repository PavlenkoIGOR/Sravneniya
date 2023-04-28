namespace Distinct_УдалениеДублей
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] drinks = { "Коньяк", "Молоко", "Кока-Кола", "Cок", "Сидр", "Cок", "Сидр", "Молоко", "Виски", "Минералка" };
            Console.WriteLine("Напитки: ");
            foreach (var item in drinks)
            {
                Console.Write(item + " ");
            }

            var allDrinks = drinks.Distinct();
            Console.WriteLine("\nПеречень без дублей: ");
            foreach (var item in allDrinks)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}