namespace DebuggingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp=new Employee ();
            int salary = 40000;
            double bonus=emp.GetBonus (salary);
            Console.WriteLine($"Salary:{salary}\tBonus:{bonus}");
        }
    }
    class Employee
    {
        public double GetBonus(int salary)
        {
            double bonus = 0;
            if (salary > 50000)
            {
                bonus = 0.1 * salary; //10%
            }
            else
            {
                bonus = 0.2 * salary; //20%
            }

            return bonus;
        }
    }
}
