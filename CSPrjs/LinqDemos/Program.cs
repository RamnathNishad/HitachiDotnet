using ListDemo;

namespace LinqDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lstEmps = Employee.GetEmps();
            var lstDept = Department.GetDepts();

            //Q1.Find the employees whose salary greater than 3000
            //SQL: select * from employee where salary >3000 order by salary desc
            //Linq:
            var res1=from e in lstEmps
                     where e.Salary>3000
                     orderby e.Salary descending
                     select e;
            //using linq extension methods and lambda operator
            res1 = lstEmps.Where(o => o.Salary > 3000)
                          .OrderByDescending(o => o.Salary);


            foreach (var e in res1) 
            {
                //Console.WriteLine($"{e.Ecode}\t{e.Ename}\t{e.Salary}\t{e.Deptid}");
            }

            //Q2. select employees with only few columns like ecode and ename
            //SQL: select ecode,ename,0.1*salary as Bonus from employee
            //LINQ:
            var res2 = from e in lstEmps
                       select new 
                       { 
                           e.Ecode, 
                           e.Ename,
                           Bonus=e.Salary*0.1
                       };

            res2 = lstEmps.Select(e => new
                                {
                                    e.Ecode,
                                    e.Ename,
                                    Bonus = e.Salary * 0.1
                                });

            foreach (var e in res2)
            {
                //Console.WriteLine($"{e.Ecode}\t{e.Ename}\t{e.Bonus}");
            }

            //Q3. display group results like sum,avg,min,max
            //SQL: select sum(salary),avg(salary) from employee
            //LINQ:
            var res3 = new
            {
                TotalSal=lstEmps.Sum(e=>e.Salary),
                AvgSal=lstEmps.Average(e=>e.Salary),
                MaxSal=lstEmps.Max(e=>e.Salary),
                MinSal=lstEmps.Min(e=>e.Salary),
                NoOfEmps=lstEmps.Count
            };

            //Console.WriteLine($"Total salary:{res3.TotalSal}");
            //Console.WriteLine($"Average salary:{res3.AvgSal}");
            //Console.WriteLine($"Minimum salary:{res3.MinSal}");
            //Console.WriteLine($"Maximum salary:{res3.MaxSal}");
            //Console.WriteLine($"No. of emps:{res3.NoOfEmps}");

            //Q4. Group by deptid
            //SQL: select deptid, sum(salary),avg(salary)
            //from employee
            //group by deptid
            //LINQ:
            var res4 = from e in lstEmps
                       group e by e.Deptid into g
                       select new
                       {
                           Deptid=g.Key,
                           TotalSal=g.Sum(e=>e.Salary),
                           AvgSal=g.Average(e=>e.Salary),
                           MaxSal=g.Max(e=>e.Salary)
                       };
            //using extension method
            res4 = lstEmps.GroupBy(e => e.Deptid)
                          .Select(g=> new
                           {
                                Deptid = g.Key,
                                TotalSal = g.Sum(e => e.Salary),
                                AvgSal = g.Average(e => e.Salary),
                                MaxSal = g.Max(e => e.Salary)
                            });

            foreach( var r in res4)
            {
                //Console.WriteLine($"{r.Deptid}\t{r.TotalSal}\t{r.MaxSal}\t{r.AvgSal}");
            }
            //Q5. Nested queries
            //Find the employees working in the deptid of employee
            //whose ecode is 101
            //SQL: select *
            //from employee
            //where deptid=(select deptid
            //              from employee
            //              where ecode=101)

            //LINQ:
            var r5 = from e in lstEmps
                     where e.Deptid==(from p in lstEmps 
                                      where p.Ecode==101 
                                      select p.Deptid).SingleOrDefault()
                     select e;

            //using extension method
            r5 = lstEmps.Where(e=>e.Deptid==(lstEmps.Where(p=>p.Ecode==101)
                                                    .Select(p=>p.Deptid)
                                                    .SingleOrDefault())
                              );

            foreach (var r in r5)
            {
                //Console.WriteLine($"{r.Ecode}\t{r.Ename}\t{r.Salary}\t{r.Deptid}");
            }

            //Q6. Joins
            //SQL : select * from employee e,department d where e.deptid=d.deptid
            //LINQ:
            var res6 = from e in lstEmps
                       join d in lstDept on e.Deptid equals d.Deptid
                       select new
                       {
                           e.Ecode,
                           e.Ename,
                           e.Salary,
                           d.Deptid,
                           d.Dname
                       };
            //using extension method
            res6 = lstEmps.Join(lstDept,
                                e=>e.Deptid,
                                d=>d.Deptid,
                                (e,d)=> new
                                {
                                    e.Ecode,
                                    e.Ename,
                                    e.Salary,
                                    d.Deptid,
                                    d.Dname
                                });

            foreach (var r in res6)
            {
                Console.WriteLine($"{r.Ecode}\t{r.Ename}\t{r.Salary}\t{r.Deptid}\t{r.Dname}");
            }
        }
    }
}
