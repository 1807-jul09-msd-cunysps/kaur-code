using System;
using EmployeeLibrary;
namespace EmployeeClient
{
    class Program
    {   
        static void Main(string[] args)
        {
            /* Person person;// reference to Person class
             person= new Person("Meghan","Damminger",32,456987);//instatianting of class object
             person.age = 25;
             person.ccn = "12341223123123";// calls the set method
             Console.WriteLine(person.ccn);//calls the get method
             string password = person.GetPassword("test", "123456");
             Console.WriteLine(password);
             string fname = Console.ReadLine();
             string lName = Console.ReadLine();
             short age = 10;long ssn = 123456;
             string info=person.GetPersonInfo(fname,lName,age,ssn);
             Console.WriteLine(info);*/
            //-------------INHERITANCE*************
            Employee emp = new Employee("John", "G", 31,345631);
            var info= emp.GetPersonInfo("Malika", "Franklin", 21, 456789);
            Console.WriteLine(info);
            Manager mgr = new Manager();
            Console.Read();
        }
    }
}
