using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    internal class Employee : IComparable<Employee>
    {
        public int Ecode { get; set; }
        public string Ename { get; set; }
        public int Salary {  get; set; }
        public int Deptid { get; set; }

        public static List<Employee> GetEmps()
        {
            return new List<Employee>
            {
                new Employee{Ecode=101,Ename="David",Salary=1111,Deptid=201},
                new Employee{Ecode=104,Ename="John",Salary=4444,Deptid=204},
                new Employee{Ecode=102,Ename="Tom",Salary=2222,Deptid=202},
                new Employee{Ecode=103,Ename="Harry",Salary=3333,Deptid=203},
                new Employee{Ecode=105,Ename="Allen",Salary=5555,Deptid=205}
            };
        }

        public int CompareTo(Employee? other)
        {
            if (this.Ecode > other.Ecode)
            {
                return 1;
            }
            else if(this.Ecode < other.Ecode) 
            { 
                return -1; 
            }
            else
            {
                return 0;
            }
        }
    }

    class SortByDeptid : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            if (x.Deptid > y.Deptid)
            {
                return -1;
            }
            else if(x.Deptid < y.Deptid)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
