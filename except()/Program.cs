namespace except__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] drinks = { "Коньяк", "Кока-Кола", "Cок", "Сидр", "Сидр", "Молоко", "Виски", "Минералка" };
            Console.WriteLine("Напитки: ");
            foreach (var item in drinks)
            {
                Console.Write(item + " ");
            }

            string[] alcohol = { "Сидр", "Виски", "Коньяк" };
            Console.WriteLine(Environment.NewLine + "Трезвый четверг: ");
            var notAlcoholDrinks = drinks.Except(alcohol); //дубли уберутся
            foreach (var item in notAlcoholDrinks)
            {
                Console.Write(item + " "); //вывод: "Кока-Кола", "Cок", "Молоко", "Минералка"
            }
        Console.ReadKey();
        }
    }
}