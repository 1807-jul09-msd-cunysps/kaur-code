using System;
using System.Text;
using EmployeeLibrary;
namespace EmployeeClient
{
    class Program
    {   
        static void Main(string[] args)
        {
            /*int a = 10;
            string b = Convert.ToString(a);
            Console.WriteLine(a+" "+b);
            string c = "123";
            int result;
            long d =Convert.ToInt64(c);
            Console.WriteLine(d);*/

             Person person=new Person();// reference to Person class
            Console.WriteLine( person.GetPersonInfo("Rubina","Ahmed","Age:21","SSN: 22356568","Credita Card Number: 123456789", "Address :123, 1st Ave 67th street, NY, 11041","Mariatal Status: single"));
             //person= new Person("Meghan","Damminger",32,456987);//instatianting of class object
            // person.age = 25;
            // person.ccn = "12341223123123";// calls the set method
            // Console.WriteLine(person.ccn);//calls the get method
           /* Console.Write("Please enter your first name ");
            var name = Console.ReadLine();
            Console.Write("Please enter you ssn ");
            var ssn = Console.ReadLine();
             string password = person.GetPassword(name,Convert.ToInt64(ssn));
             Console.WriteLine(password);*/
            /* string fname = Console.ReadLine();
             string lName = Console.ReadLine();
             short age = 10;long ssn = 123456;
             string info=person.GetPersonInfo(fname,lName,age,ssn);
             Console.WriteLine(info);*/
            //-------------INHERITANCE*************
           /* Employee emp = new Employee("John", "G", 31,345631);
            var info= emp.GetPersonInfo("Malika", "Franklin", 21, 456789);
            Console.WriteLine(info);
            Manager mgr = new Manager();*/
            Console.Read();
        }
    }
}
