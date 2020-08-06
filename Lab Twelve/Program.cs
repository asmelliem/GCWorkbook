using System;

namespace LabTwelve
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person("Ada", "Canton address");
            Console.WriteLine(person.ToString());

            var student = new Student("Alan", "Livonia address", "Environmental Science", 3, 2400.40);
            Console.WriteLine(student.ToString());

            var staff = new Staff("Jake", "Dearborn address", "UM-D", 80000.50);
            Console.WriteLine(staff.ToString());
        }
    }
}
