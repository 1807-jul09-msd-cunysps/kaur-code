using System;

namespace EmployeeLibrary
{
    public class Person
    {
        //Git Comment sample
        long ssn;
        string creditCardNum;
        //property
        public string ccn {
            get {
                if (age > 15)
                    return creditCardNum;
                else
                    return "Not allowed";
            } 
            set {
                creditCardNum = value;
            }
        }
        //autonomous property
        public string cvv { get;}
        public  short age=18;
        public string firstName, lastName;

        /// <summary>
        /// Constructor
        /// </summary>
        public Person()
        {
            ssn = 87456;
            age = 44;
            firstName = "Carol";
            lastName = "Baxtor";
            creditCardNum = "1234123412341234";
           // Console.WriteLine($"Name :{firstName} {lastName}, Age : {age}, SSN : {ssn}");
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
        public string GetPassword(string firstName, long ssn)
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
        public string GetPersonInfo(string firstName)
        {
            return $"Name :{firstName}";
        }
        public string GetPersonInfo(string firstName, string lastName)
        {
            return $"Name :{firstName} {lastName}";
        }
        public  string GetPersonInfo(string firstName, short age)
        {
            return $"Name :{firstName} , Age : {age}";
        }
        public  string GetPersonInfo(short age, string firstName)
        {
            return $"Name :{firstName} , Age : {age}";
        }
        public  string GetPersonInfo(string firstName, string lastName, short age)
        {
            return $"Name :{firstName} {lastName}, Age : {age}";
        }
        public string GetPersonInfo(string firstName, string lastName, short age, long ssn)
        {
            return $"Name :{firstName} {lastName}, Age : {age}, SSN : {ssn}";
        }
        public  string GetPersonInfo(string firstName, string lastName, short age, long ssn,string creditCardNum)
        {
            return $"Name :{firstName} {lastName}, Age : {age}, SSN : {ssn}, Credit Card Number: {creditCardNum}";
        }
        public string GetPersonInfo(int id, params string[] data)
        {
            string info = "";
            for (int i = 0; i < data.Length-1; i++)
            {
                info += data[i] + " ";    
            }
            return info;
        }

    }
}
