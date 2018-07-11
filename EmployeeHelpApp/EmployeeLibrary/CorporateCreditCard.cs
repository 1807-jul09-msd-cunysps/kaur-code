using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class CorporateCreditCard:IAmexCard,IBOICard
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
