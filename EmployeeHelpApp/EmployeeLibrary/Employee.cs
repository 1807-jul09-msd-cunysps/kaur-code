using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public  class Employee: Person
    {
        //SALARY COMPONENTS
        public decimal bSal { get; set; } = 75.50M;
        public decimal hra { get; set; } = 50.75M;
        public decimal ta { get; set; } = 40.65M;
        public decimal tax { get; set; } = 8.75M;
        public decimal tds { get {
                return bSal * (tax/100);
            }
        }
        public decimal salary {
            get
            {
                return hra + ta + bSal - tds;
            }
        }

      /*  public override string GetPersonInfo(string firstName, string lastName, short age, long ssn)
        {
            return $"Name :{firstName} {lastName}, Age : {age}, SSN : {ssn}. Salary : {salary}";
        }*/
        public Employee()
        {

        }
        public Employee(string fn, string ln, short age, long ssn) : base(fn, ln,  age, ssn)
        {

        }
    }
   public class Manager:Employee
    {
        public Manager():base("test","test", 12,123)
        {
            Console.WriteLine("cALLING mANAGER");
        }
    }
}
