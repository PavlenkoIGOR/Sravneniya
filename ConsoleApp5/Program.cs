///
///Напишите метод, который соберет всех учеников всех классов в один список, используя LINQ.
///

namespace HW15._1
{
    class Car
    {
        public string Model;
        public string Manufacturer;
    }
    class Manufacturer
    {
        public string Country;
        public string Name;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Список моделей
            var cars = new List<Car>()
            {
                new Car() { Model  = "SX4", Manufacturer = "Suzuki"},
                new Car() { Model  = "Grand Vitara", Manufacturer = "Suzuki"},
                new Car() { Model  = "Jimny", Manufacturer = "Suzuki"},
                new Car() { Model  = "Land Cruiser Prado", Manufacturer = "Toyota"},
                new Car() { Model  = "Camry", Manufacturer = "Toyota"},
                new Car() { Model  = "Polo", Manufacturer = "Volkswagen"},
                new Car() { Model  = "Passat", Manufacturer = "Volkswagen"},
            };

            // Список автопроизводителей
            var manufacturers = new List<Manufacturer>()
            {
                new Manufacturer() { Country = "Japan", Name = "Suzuki" },
                new Manufacturer() { Country = "Japan", Name = "Toyota" },
                new Manufacturer() { Country = "Germany", Name = "Volkswagen" },
            };

            // Выборка + группировка
            var result2 = manufacturers.GroupJoin(    //Позволяет одновременно с тем, что мы делали выше (соединение последовательностей), произвести группировку.
               cars, // первый набор данных
               m => m.Name, // общее свойство второго набора
               car => car.Manufacturer, // общее свойство первого набора
               (m, crs) => new  // результат выборки
               {
                   Name = m.Name,
                   Country = m.Country,
                   Cars = crs.Select(c => c.Model)
               });

            // Вывод:
            foreach (var team in result2)
            {
                Console.WriteLine(team.Name + ":");

                foreach (string car in team.Cars)
                    Console.WriteLine(car);

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
