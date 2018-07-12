using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactLibrary;
namespace ContactClient
{
    class DatabaseNotResponding:ApplicationException
    {
        public DatabaseNotResponding():base(message)
        {
            // logic to exception
        }
    }
    class Program
    {
        static int Result(int a, int b)
        {
            try
            {
                throw new DatabaseNotResponding();
            }
            catch (Exception ex)
            {

            }
            var logger = NLog.LogManager.GetCurrentClassLogger();
            ArrayList result = new ArrayList();
            result.Add("test 1");
            result.Add("test 2");
            result.Add("test 3");
            result.Add(5);
            result.Add('a');
            result.Add(a);
            result.Add(b);
            try
            {
                foreach (string item in result)
                {
                    Console.WriteLine(item);
                }
            }
            catch (DivideByZeroException ex)
            {
                //Log the exception
                
                logger.Info(ex.Message);
                Console.WriteLine("Please provide non zero denominator");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //closing resources code here
                Console.WriteLine("I always make sure to close unmanaged resources");
            }

            return 0;
        }
        static void Main(string[] args)
        {
            #region Exception
            var output = Result(999999999,9);
            Console.WriteLine(output);
            #endregion

            #region LINQ
          /*  Person p = new Person();
            var persons = p.Get();
            //LINQ-Language Integrate Query
            //Query Syntax
            /*var query = from p1 in persons
                        where p1.firstName.StartsWith("T")
                        select p1;
           var query = from p1 in persons
                         where p1.address.houseNum.Equals("121")
                         select p1;

            int[] marks = new int[] {45,56,89,78,98 };

            /*var query = from m in marks
                        where m > 60 && m<80
                        select m;
            foreach (var item in query)
            {
                Console.WriteLine($"{item.firstName} {item.lastName} Phone +{item.phone.countrycode+"-"+item.phone.areaCode+"-"+item.phone.number}");
            }*/
            #endregion
            //Method Syntax
        }
    }
}
