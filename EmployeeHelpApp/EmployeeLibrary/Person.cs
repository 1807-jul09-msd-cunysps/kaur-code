using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Person
    {
        long ssn;
        short age;
        string firstName, lastName;

        public string GetPersonInfo(string firstName, string lastName, short age, long ssn)
        {
            return $"Name :{firstName} {lastName}, Age : {age}, SSN : {ssn}";
        }
    }
}
