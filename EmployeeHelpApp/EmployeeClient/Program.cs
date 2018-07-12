using System;
using System.Text;
using EmployeeLibrary;
namespace EmployeeClient
{
    class Point
    {
        public int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Programs
    {   
        static void Main(string[] args)
        {
            Point a = new Point(10, 10);
            Point b = a;//
            a.x = 20;
            Console.WriteLine(b.x);

            /*int a = 10;
            string b = Convert.ToString(a);
            Console.WriteLine(a+" "+b);
            string c = "123";
            int result;
            long d =Convert.ToInt64(c);
            Console.WriteLine(d);*/

            /*Person person=new Person();// reference to Person class
           Console.WriteLine( person.GetPersonInfo("Rubina","Ahmed","Age:21","SSN: 22356568","Credita Card Number: 123456789", "Address :123, 1st Ave 67th street, NY, 11041","Mariatal Status: single"));
            */
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
            // Console.WriteLine(info);
             Manager mgr = new Manager();*/

            //------------INTERFACE-----------------
           /* Employee emp1 = new Employee();
            emp1.firstName = "Tanisha";
            emp1.lastName = "Israel";
            emp1.creditScore = 800;

            IAmexCard amexcc = new CorporateCreditCard();// upcasting
            var discount=amexcc.Offer(emp1.creditScore);
            
            IBOICard boiCard = new CorporateCreditCard();
            boiCard.CreditLimit(450);
            //var discountBoi= boiCard.Offer(750);
            //Console.WriteLine(discountBoi);
            //var discount=card.Offer(emp1.creditScore);
            if (discount==25)
                Console.WriteLine("you got 25 % off on yearly fee");
            else if (discount == 30)
                Console.WriteLine("you got 30 % off on yearly fee");
            else if(discount==15)
                Console.WriteLine("you got 15 % off on yearly fee");
            else if (discount == 10)
                Console.WriteLine("you got 10 % off on yearly fee");
            else if (discount == 20)
                Console.WriteLine("you got 20 % off on yearly fee");
            else
                Console.WriteLine("Not Eligible for discount dur to low credit score");*/
            Console.Read();
        }
    }
}
