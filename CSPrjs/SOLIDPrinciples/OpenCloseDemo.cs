using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{

    interface ICustomerDiscount
    {
        double GetDiscount(int amount);
    }

    class GoldCustomer : ICustomerDiscount
    {
        public double GetDiscount(int amount)
        {
            return 0.2 * amount;
        }
    }
    class SilverCustomer : ICustomerDiscount
    {
        public double GetDiscount(int amount)
        {
            return 0.2 * amount;
        }
    }

    class RegularCustomer : ICustomerDiscount
    {
        public double GetDiscount(int amount)
        {
            return 0.1 * amount;
        }
    }
    class GetCustomerFactory
    {
        public static ICustomerDiscount Create(string customerType)
        {
            if(customerType=="gold")
            {
                return new GoldCustomer();
            }
            else if(customerType=="silver")
            {
                return new SilverCustomer();
            }
            else
            {
                return new RegularCustomer();
            }
        }
    }


    internal class OpenClosedDemo
    {
        public double GetDiscount(string customerType,int amount)
        {
            var customer = GetCustomerFactory.Create(customerType);
            double discount=customer.GetDiscount(amount);
            //get the respective Cutomer object based on customer type

            return discount;
        }

    }


}
