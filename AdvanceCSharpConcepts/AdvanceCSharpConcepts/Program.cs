using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharpConcepts
{
    //1.create delegate that matches the method definition
    delegate void DelWelcome(string n);
    delegate double delArea(double r);
    class Program
    {
        static void Main(string[] args)// main thread
        {
            // delArea handlerArea = new delArea(calAreaCircle);
            //Anonymous methods!! 
            delArea handlerArea = delegate(double r)
            {
                double result = Math.PI * r * r;
                return result;
            };

            //Delegate Action with lambda expressions
            Action<string> handlerWelcome = name => Console.WriteLine($"{name} Welcome to CUNY-Revature");
            handlerWelcome("Tanisha");

            Func<double,double, double> delRectAreaHandler = (l,b) => (l*b);
            double h = 5;
            double w = 2;
            double area= delRectAreaHandler(h,w);
            Console.WriteLine($"The area of Rectangle with length {h}  and width {w} is {area} ");

            #region RunbasicsOf Delegates
            //2. Instantiate a delegate
          /*  DelWelcome handlerWelcome = new DelWelcome(Welcome);
            handlerWelcome += Induction;
            handlerWelcome += Training;
            handlerWelcome += Assesment;
            //3. Invoke delegate
            Console.WriteLine("************Before removing Induction*********");
            handlerWelcome("Isaac");
            Console.WriteLine("************After removing Induction*********");
            handlerWelcome -= Induction;
            handlerWelcome("Sabrina");
            //var dels=   handlerWelcome.GetInvocationList();
            //foreach (var item in dels)
            //{
            //    Console.WriteLine(item.Method);
            //}*/
            #endregion
            #region RunAsyncAwait
            //TestMethod();
            //Console.WriteLine("Main Thread");
            #endregion
            Console.Read();
        }

        #region DelegatesMethodsTobeTied
        //static methods 
        public static void Welcome(string name)
        {
            Console.WriteLine($"Welcome {name} to CUNY-Revature");
        }
        static void Induction(string associate)
        {
            Console.WriteLine($"Hey {associate}, Please go to room 216 for induction");
        }
        static void Training(string name)
        {
            Console.WriteLine($"Please go to 218 for .net batch");
        }
        static void Assesment(string name)
        {
            Console.WriteLine($"Please go to 218 for one on one assessment");
        }
        #endregion
       /* static double calAreaCircle(double radius)
        {
            double result = Math.PI * radius * radius;
            return result;
        }*/
        #region AsyncAndAwait
        /* static async void TestMethod()
         {
             LongTask();
             //await Task.Run(new Action(LongTask));// here it will create new thread
             Console.WriteLine("Calling Method");
         }
         static void LongTask()
         {
             System.Threading.Thread.Sleep(20000);
             Console.WriteLine("Executing Long Task");
         }*/
        #endregion
    }
}
