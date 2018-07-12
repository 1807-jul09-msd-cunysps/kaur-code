using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public interface IAmexCard : ICreditCard
    {
        int Offer(int creditScore);
    }

}
