using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Employee
    {
        int ecode;
        string ename;
        public Employee(int ecode,string ename)
        {
            this.ecode = ecode;
            this.ename = ename;
        }

        public override string ToString()
        {
            return $"{ecode}\t{ename}";
        }
    }
}
