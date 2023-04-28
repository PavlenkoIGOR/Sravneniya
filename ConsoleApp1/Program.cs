namespace ConsoleApp1
{
    class Contact
    {
        public string Name { get; set; }
        public long Phone;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var contacts = new List<Contact>()
{
   new Contact() { Name = "Андрей", Phone = 79994500508 },
   new Contact() { Name = "Сергей", Phone = 799990455 },
   new Contact() { Name = "Иван", Phone = 79999675334 },
   new Contact() { Name = "Игорь", Phone = 8884994 },
   new Contact() { Name = "Анна", Phone = 665565656 },
   new Contact() { Name = "Василий", Phone = 3434 }
};
            var q = contacts.Where(contact => contact.Phone.ToString().Length < 11 || !contact.Phone.ToString().StartsWith('7'));
            var q1 = contacts.Where(contact => contact.Phone.ToString().Length < 11).Count();

            foreach (var item in q)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine($"количество контактов с некорректным номером: {q1}");

            Console.ReadKey();
        }
    }
}