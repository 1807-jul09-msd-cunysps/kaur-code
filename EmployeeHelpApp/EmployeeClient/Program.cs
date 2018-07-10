using System;
using EmployeeLibrary;
namespace EmployeeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            string info=person.GetPersonInfo("Pushpinder", "Kaur", 55, 123456);
            Console.WriteLine(info);
            Console.Read();
        }
    }
}
