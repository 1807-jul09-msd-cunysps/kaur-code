using System;

namespace EmployeeLibrary
{
    sealed class NotToBeExtended { }
    public abstract class Species { }
    public abstract class Human{}
    public abstract partial class Person//:Human
    {
        //Git Comment sample
        long ssn;
        public long Ssn {
            get { return ssn; }
            set { ssn = value; } }
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
        public  string cvv { get;}
        public  short age=18;
        public string firstName, lastName;
    }
}
