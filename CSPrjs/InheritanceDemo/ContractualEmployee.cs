using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class ContractualEmployee : Employee
    {
        int wages;
        public ContractualEmployee(int ecode,string ename, int wages)
            :base(ecode,ename)
        {
            this.wages = wages;
        }
        public void Display()
        {
            Console.WriteLine($"{base.ToString()}\t{wages}");
        }
    }
}
