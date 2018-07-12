using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactLibrary;
namespace ContactClient
{
    class Program
    {

        static void Main(string[] args)
        {
            Person p = new Person();
            var persons = p.Get();
            //LINQ-Language Integrate Query
            //Query Syntax
            /*var query = from p1 in persons
                        where p1.firstName.StartsWith("T")
                        select p1;*/
           var query = from p1 in persons
                         where p1.address.houseNum.Equals("121")
                         select p1;

            int[] marks = new int[] {45,56,89,78,98 };

            /*var query = from m in marks
                        where m > 60 && m<80
                        select m;*/
            foreach (var item in query)
            {
                Console.WriteLine($"{item.firstName} {item.lastName} Phone +{item.phone.countrycode+"-"+item.phone.areaCode+"-"+item.phone.number}");
            }
            //Method Syntax
        }
    }
}
