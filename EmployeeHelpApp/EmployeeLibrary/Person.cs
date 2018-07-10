using System;

namespace EmployeeLibrary
{
    public class Person
    {
        long ssn;
        short age;
        string firstName, lastName;
        /// <summary>
        /// Constructor
        /// </summary>
        public Person()
        {
            ssn = 87456;
            age = 44;
            firstName = "Carol";
            lastName = "Baxtor";
            Console.WriteLine($"Name :{firstName} {lastName}, Age : {age}, SSN : {ssn}");
        }
        /// <summary>
        /// parameterised constructor
        /// </summary>
        public Person(string firstName, string lastName, short age, long ssn)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.ssn = ssn;
            Console.WriteLine($"Name :{firstName} {lastName}, Age : {age}, SSN : {ssn}");
        }
        /// <param name="firstName"></param>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public string GetPassword(string firstName, string ssn)
        {
            string password="", joinstr;
            int length;
            joinstr = firstName + ssn;
            length = joinstr.Length - 1;
            while (length>=0)
            {
                password = password + joinstr[length];
                length--;
            }
            return password;
        }
        public string GetPersonInfo(string firstName, string lastName, short age, long ssn)
        {
            return $"Name :{firstName} {lastName}, Age : {age}, SSN : {ssn}";
        }
    }
}
