namespace GroupBy
{
    internal class Program
    {
        class Car
        {
            public string Name;
            public string CountryCode;
            public Car(string Name, string Company)
            {
                this.Name = Name;
                this.CountryCode = Company;
            }
        }

        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Car("Suzuki", "JP"),
                new Car("Toyota", "JP"),
                new Car("Opel", "DE"),
                new Car("Kamaz", "RUS"),
                new Car("Lada", "RUS"),
                new Car("Honda", "JP")
            };

            var groupedCars = cars.GroupBy(car => car.CountryCode); //в переменную groupedCars передаются сформированные группы

            foreach (var item in groupedCars)
            {
                Console.WriteLine(item.Key + ":");
                foreach (var car in item)
                {
                    Console.WriteLine(car.Name);
                }
            }


            //var carsByCountry2 = cars
            //   .GroupBy(car => car.CountryCode)
            //   .Select(g => new
            //   {
            //       Name = g.Key,
            //       Count = g.Count(),
            //       Cars = g.Select(c => c)
            //   });
            //foreach (var car in carsByCountry2) 
            //{
            //    Console.WriteLine(car.Name);
            //    foreach (var item in car.Cars)
            //    {
            //        Console.WriteLine($"\t{item.Name}");
            //    }
            //}

            Console.ReadKey();
        }
    }
}