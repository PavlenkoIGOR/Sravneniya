namespace Union_Объединение
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] drinks1 = { "Кока-Кола", "Cок", "Молоко", "Минералка" };
            Console.WriteLine("Напитки1: ");
            foreach (var item in drinks1)
            {
                Console.Write(item + " ");
            }

            Console.Write("\nАлкогольная продукция: ");
            string[] drinks2 = { "Сидр", "Виски", "Коньяк", "Сок" };
            foreach (var item in drinks2)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine(Environment.NewLine + "Union: ");
            var allDrinks = drinks1.Union(drinks2); //объединение двух списков. дубли удалятся. drinks2 добавился осле drinks1
            foreach (var item in allDrinks)
            {
                Console.Write(item + " "); //вывод: Кока-Кола Cок Молоко Минералка Сидр Виски Коньяк
            }

            Console.WriteLine(Environment.NewLine + "Concat: ");
            var allDrinks2 = drinks1.Concat(drinks2);
            foreach (var item in allDrinks2)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}