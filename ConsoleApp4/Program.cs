namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {
                "innokentii@example.com",
                "serge@example.com",
                "serg@gmail.com",
                "valera@gmail.com"
            };


            var str = list.Where(x => x.Contains("@example"));
            foreach (var x in str)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}