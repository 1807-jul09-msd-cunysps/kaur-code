using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public interface IBOICard : ICreditCard
    {

        int Offer(int creditScore);
        int CreditLimit(int bsal);
       
    }
}
