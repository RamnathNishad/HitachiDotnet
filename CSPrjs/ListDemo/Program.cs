namespace ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lstNums = new List<int> { 20, 10, 30, 50, 40 };

            lstNums.Sort();

            Console.WriteLine("Traversing using foreach");
            foreach (var i in lstNums)
            {
                Console.WriteLine(i);
                //lstNums.Add(100); not allowed
            }

            var lstEmps=Employee.GetEmps();
            lstEmps.Sort(new SortByDeptid());

            Console.WriteLine("Traversing using foreach");
            foreach (var e in lstEmps)
            {
                Console.WriteLine($"{e.Ecode}\t{e.Ename}\t{e.Salary}\t{e.Deptid}");
            }

            Console.WriteLine("\nTraversing using IEnumerator<>");
            var ie = lstEmps.GetEnumerator();
            while (ie.MoveNext())
            {
                var emp= ie.Current;
                Console.WriteLine($"{emp.Ecode}\t{emp.Ename}\t{emp.Salary}\t{emp.Deptid}");
            }

            Console.WriteLine("\nTraversing for-index loop");
            for (int i = 0; i < lstEmps.Count; i++)
            {
                //if(i==1)
                //{
                //    lstEmps.RemoveAt(i); //allowed
                //}
                var d= lstEmps[i];
                Console.WriteLine($"{d.Ecode}\t{d.Ename}\t{d.Salary}\t{d.Deptid}");
            }
        }
    }
}
