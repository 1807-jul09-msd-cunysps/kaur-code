using System;
using EmployeeLibrary;
namespace EmployeeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person;// reference to Person class
            person= new Person("Meghan","Damminger",32,456987);//instatianting of class object
            string password = person.GetPassword("test", "123456");
            Console.WriteLine(password);
            string fname = Console.ReadLine();
            string lName = Console.ReadLine();
            short age = 10;long ssn = 123456;
            string info=person.GetPersonInfo(fname,lName,age,ssn);
            Console.WriteLine(info);
            Console.Read();
        }
    }
}
