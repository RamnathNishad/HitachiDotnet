using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    internal class AdapterDemo
    {
    }

    interface ICustomer
    {
        int Id { get; }
        string Name { get; }
        string GetStringDetails();
    }

    class Customer :ICustomer
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        
        public string GetStringDetails()
        {
            return $"{Id}\t{Name}";
        }
    }

    class EmployeeAdapter
    {
        ICustomer _customer;
        public EmployeeAdapter(ICustomer customer)
        {
            this._customer = customer;
            //set the data values of customer
        }
        public string GetJsonDetails()
        {
            return "{Id:" + _customer.Id + ",Name:" + _customer.Name + "}";
        }
    }
    class User
    {
        public void DisplayDetails()
        {
            EmployeeAdapter adapter = new EmployeeAdapter(new Customer());
            Console.WriteLine(adapter.GetJsonDetails());      
        }
    }
}
