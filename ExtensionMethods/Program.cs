using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = new DateTime(2020, 8, 19, 8, 10, 45);
            Console.WriteLine(date.ElapsedTime());

            var stringStudent = "Good morning dear students!";
            Console.WriteLine(stringStudent.Cut(10));
        }
    }
}
