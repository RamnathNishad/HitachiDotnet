using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    internal class Employee
    {
        int ecode;
        string ename;
        int salary;
        int deptid;

        public Employee(int ecode,string ename,int salary,int deptid)
        {
            this.ecode = ecode;
            this.ename = ename;
            this.salary = salary;
            this.deptid = deptid;
            Console.WriteLine("constructor is called");
        }
        public void Display()
        {
            Console.WriteLine($"{ecode}\t{ename}\t{salary}\t{deptid}\t{GetBonus()}");
        }
        double GetBonus()
        {
            if(salary>50000)
            {
                return 0.1 * salary;
            }
            else
            {
                return 0.2 * salary;
            }
        }
        ~Employee() 
        {
            Console.WriteLine("destructor is called");
        }

    }
}
