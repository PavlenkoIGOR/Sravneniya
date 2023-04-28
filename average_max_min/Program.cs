namespace average_max_min
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
{
   new Student {Name="Андрей", Age=23 },
   new Student {Name="Сергей", Age=27 },
   new Student {Name="Дмитрий", Age=29 }
};

            // найдем возраст самого старого студента ( 29 )
            var oldest = students.Max(s => s.Age);

            // самого молодого ( 23 )
            var youngest = students.Min(s => s.Age);

            //  и средний возраст ( 26,3 )
            var average = students.Average(s => s.Age);

            Console.ReadKey();
        }
    }
}