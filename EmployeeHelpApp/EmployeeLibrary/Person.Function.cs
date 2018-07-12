using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public abstract partial class Person
    {
        /// <summary>
        /// Constructor
        /// </summary>
        #region OOPBasics
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

        public abstract bool IsCitizen(long ssn);

        /// <param name="firstName"></param>
        /// <param name="ssn"></param>
        /// <returns></returns>
        #region OverloadExample
        public string GetPassword(string firstName, long ssn)
        {
            string password = "", joinstr;
            int length;
            joinstr = firstName + ssn;
            length = joinstr.Length - 1;
            while (length >= 0)
            {
                password = password + joinstr[length];
                length--;
            }
            return password;
        }
        public virtual string GetPersonInfo(string firstName)
        {
            return $"Name :{firstName}";
        }
        public virtual string GetPersonInfo(string firstName, string lastName)
        {
            return $"Name :{firstName} {lastName}";
        }
        public string GetPersonInfo(string firstName, short age)
        {
            return $"Name :{firstName} , Age : {age}";
        }
        public string GetPersonInfo(short age, string firstName)
        {
            return $"Name :{firstName} , Age : {age}";
        }
        public string GetPersonInfo(string firstName, string lastName, short age)
        {
            return $"Name :{firstName} {lastName}, Age : {age}";
        }
        public string GetPersonInfo(string firstName, string lastName, short age, long ssn)
        {
            return $"Name :{firstName} {lastName}, Age : {age}, SSN : {ssn}";
        }
        public string GetPersonInfo(string firstName, string lastName, short age, long ssn, string creditCardNum)
        {
            return $"Name :{firstName} {lastName}, Age : {age}, SSN : {ssn}, Credit Card Number: {creditCardNum}";
        }
        public string GetPersonInfo(int id, params string[] data)
        {
            string info = "";
            for (int i = 0; i < data.Length - 1; i++)
            {
                info += data[i] + " ";
            }
            return info;
        }
        #endregion
        #endregion
    }
    public class CorporateCreditCard:IAmexCard, IBOICard
    {
        public string creditCardNum { get; }
        public string cvv { get; }
        public string pin { get; set; }
        int discountedfee;
        int IAmexCard.Offer(int creditScore)
        {
            int discountedFee = 0;
            if ((creditScore >= 600) && (creditScore <= 700))
                discountedFee = 10;
            else if ((creditScore > 700) && (creditScore < 750))
                discountedFee = 20;
            else if (creditScore > 750)
                discountedFee = 30;
            else
                discountedFee = 0;
            return discountedFee;
        }

        int IBOICard.Offer(int creditScore)
        {

            int discountedFee = 0;
            if ((creditScore >= 650) && (creditScore <= 700))
                discountedFee = 15;
            else if ((creditScore > 700) )
                discountedFee = 25;
            else
                discountedFee = 0;
            return discountedFee;
        }
        public int CreditLimit(int bsal)
        {
            return bsal * 25;
        }
    }
}
