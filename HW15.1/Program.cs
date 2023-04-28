///
///Напишите метод, который соберет всех учеников всех классов в один список, используя LINQ.
///

namespace HW15._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
                    new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
                    new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
                    new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
                };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
            Console.ReadKey();
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            var arrStudents = from g in classes
                              from student in g.Students
                              select student;

            return arrStudents.ToArray();
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}
