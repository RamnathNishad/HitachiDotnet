namespace PropertiesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            //object-initializer syntax
            Employee emp =  new Employee 
            {
                Ecode=101,
                Ename="Ravi",
                Salary=1111,
                Deptid=201 
            };
            Console.WriteLine($"{emp.Ecode}\t{emp.Ename}\t{emp.Salary}\t{emp.Deptid}");
        }
    }

    class Employee
    {
        public int Ecode { get; set; }
        public string Ename { get; set; }
        public int Salary {  get; set; }
        public int Deptid { get; set; }

        //int ecode;
        //public int Ecode 
        //{ 
        //    get { return this.ecode; } 
        //    set { this.ecode = value; } 
        //}

        //public void SetEcode(int ecode) { this.ecode = ecode; }
        //public int GetEcode() {   return this.ecode;  }
    }
}
