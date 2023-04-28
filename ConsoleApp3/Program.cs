/*
Некоторые из них имеют реальный email-адрес, а некоторые — фейковый (те, которые в домене example).
Нам нужно разбить их на две группы: фейковые и реальные, и вывести результат в консоль.
Решите эту задачу с помощью группировки.
*/

namespace ConsoleApp1
{
    class Contact
    {
        public string Name;
        public long Number;
        public string Address;
        public Contact(string Name, long Number, string Address)
        {
            this.Name = Name;
            this.Number = Number;
            this.Address = Address;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", 799900000013, "serg@gmail.com"));
            phoneBook.Add(new Contact("Иван", 799900000013, "John@gmail.com"));
            phoneBook.Add(new Contact("Иннокентий", 799900000013, "innokentii@example.com"));

            var grouped = phoneBook.GroupBy(phoneB => phoneB.Address.Contains("@example"));

            foreach (var x in grouped)
            {
                Console.WriteLine($"Группа {x.Key} адресов");
                foreach (var y in x)
                {
                    Console.WriteLine(y.Name + " " + y.Number);
                }

            }

            Console.ReadKey();
        }
    }
}