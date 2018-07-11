using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public interface ICreditCard
    {
        //properties, methods, events, indexers
        string creditCardNum { get; }
        string cvv { get; }
        string pin { get; set; }
        
    }
}
