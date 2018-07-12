using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public static class Compare<T>
    {   
        public static bool CompareToObj(T a, T b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else
                return false;
        }
    }
}
