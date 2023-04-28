namespace Intersect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Shop1 = { "Коньяк", "Кока-Кола", "Cок", "Сидр", "Молоко", "Виски", "Минералка" };
            Console.WriteLine("Напитки магазина1: ");
            foreach (var item in Shop1)
            {
                Console.Write(item + " ");
            }

            string[] shop2 = { "Сидр", "Виски", "Cок", "Коньяк", "Кока-Кола" };
            Console.WriteLine("\n\nНапитки магазина2: ");
            foreach (var item in shop2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(Environment.NewLine + "\nОдинаковая продукция в магазинах 1 и 2: ");
            var notUniqueDrinks = Shop1.Intersect(shop2); //вывод совпадающих значений из двух списков
            foreach (var item in notUniqueDrinks)
            {
                Console.Write(item + " "); //вывод: Коньяк Кока-Кола Cок Сидр Виски
            }
            Console.ReadKey();
        }
    }
}