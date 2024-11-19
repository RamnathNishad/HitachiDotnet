using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class PermanentEmployee : Employee
    {
        int salary;
        public PermanentEmployee(int ecode,string ename, int salary) 
            : base(ecode,ename) //ctor chaining
        {
            this.salary = salary;
        }
        public void Display()
        {
            Console.WriteLine($"{base.ToString()}\t{salary}");
        }
    }
}
