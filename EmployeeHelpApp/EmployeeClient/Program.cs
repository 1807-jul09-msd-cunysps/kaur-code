using System;
using System.Text;
using EmployeeLibrary;
namespace EmployeeClient
{
    /// <summary>
/// Structs Demo
/// </summary>
    class Point
    {
        public int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    /// <summary>
    /// Entry point
    /// </summary>
    class Programs
    {   
        static void Main(string[] args)
        {
            #region Arrays
            string[] names;// declaration
            names = new string[10];
            names[0] = "Jase";
            names[1] = "Bunmi";
            names[2] = "Isaac";
            names[3] = "Joe";
            /* for (int i = 0; i < names.Length; i++)
             {
                 Console.WriteLine(names[i]);
             }*/
            /*foreach (string name in names)
            {
                Console.WriteLine(name);
            }*/
            int x = 4, y = 3,z=2;
            int[,,] matrix = new int[x,y,z];
            matrix[0,0,0] = 1;
            Console.WriteLine(matrix.GetLength(2));
           
            Console.WriteLine(matrix.Rank);
            Console.WriteLine(matrix.Length);
            #endregion
            #region GenericsExample
            /* Console.WriteLine(Compare<int>.CompareToObj(10,20));
             Console.WriteLine(Compare<string>.CompareToObj("Briyana", "Briyana"));
             Employee e1 = new Employee();
             e1.firstName = "Joy";
             e1.ccn = "123456789123";
             //Employee e2 = e1; // returns comparison as true
             Employee e2 = new Employee();
             e2.firstName = "Joy";
             e2.ccn = "123456789123";
             Console.WriteLine(Compare<Employee>.CompareToObj(e1, e2));// returns comparison as false*/
            #endregion
            #region StaticCode
            //---------Test 
            /*  Console.WriteLine(Math.Sqrt(25));
              Console.WriteLine("Please select the convertor direction");
              Console.WriteLine("1. From Celsius to Fahrenheit.");
              Console.WriteLine("2. From Fahrenheit to Celsius.");
              Console.Write(":");

              string selection = Console.ReadLine();
              double F, C = 0;

              switch (selection)
              {
                  case "1":
                      Console.Write("Please enter the Celsius temperature: ");
                      F = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                      Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
                      break;

                  case "2":
                      Console.Write("Please enter the Fahrenheit temperature: ");
                      C = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                      Console.WriteLine("Temperature in Celsius: {0:F2}", C);
                      break;

                  default:
                      Console.WriteLine("Please select a convertor.");
                      break;
              }

              // Keep the console window open in debug mode.
              Console.WriteLine("Press any key to exit.");
              Console.ReadKey();*/

            #endregion
            #region StructsCall
            /*Point a = new Point(10, 10);
            Point b = a;//
            a.x = 20;
            Console.WriteLine(b.x);*/
            #endregion
            #region BoxingAndUnboxing
            /*int a = 10;
            string b = Convert.ToString(a);
            Console.WriteLine(a+" "+b);
            string c = "123";
            int result;
            long d =Convert.ToInt64(c);
            Console.WriteLine(d);*/
            #endregion
            #region OOP
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
            #endregion
            Console.Read();
        }
    }
}
