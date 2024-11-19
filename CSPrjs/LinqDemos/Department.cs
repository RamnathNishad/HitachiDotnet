using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemos
{
    internal class Department
    {
        public int Deptid {  get; set; }
        public string Dname { get; set; }

        public static List<Department> GetDepts()
        {
            return new List<Department>
            {
                new Department{Deptid=201,Dname="Account"},
                new Department{Deptid=202,Dname="Sales"},
                new Department{Deptid=203,Dname="Admin"}
            };
        }
    }
}
