using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharpConcepts
{
    class Program
    {
        static void Main(string[] args)// main thread
        {
            #region RunAsyncAwait
            //TestMethod();
            //Console.WriteLine("Main Thread");
            #endregion
            Console.Read();
        }
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
