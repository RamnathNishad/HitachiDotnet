namespace SOLIDPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SRP------------------
            //Employee employee = new Employee
            //{
            //    Ecode=101,
            //    Ename="Ravi",
            //    Salary=70000
            //};

            //employee.Display();
            //O----OpenClosed principle
            //OpenClosedDemo demo=new OpenClosedDemo();
            //string customer = "regular";
            //int amount = 5000;

            //double discount= demo.GetDiscount(customer, amount);
            //Console.WriteLine($"Type:{customer}\nAmount:{amount}\nDiscount:{discount}");

            //L---Liskov Substitution Principle
            //LSPPrinciple lsp = new LSPPrinciple();
            //lsp.Display();

            //D---->Dependency Principle

            EmailService emailService = new EmailService();

            Notification notification = new Notification(emailService);
            notification.Notify("2mrw is holiday");

            SmsService smsService = new SmsService();

            notification=new Notification(smsService);
            notification.Notify("2mrw is holiday");

        }
    }

    class Employee
    {
        public int Ecode { get; set; }
        public string Ename { get; set; }
        public int Salary { get; set; }

        public double GetBonus()
        {
            double bonus = 0;
            if (Salary > 50000)
            {
                bonus = 0.1 * Salary;
            }
            else
            {
                bonus = 0.2 * Salary;
            }
            return bonus;
        }
        public void Display()
        {    
            Console.WriteLine($"{Ecode}\t{Ename}\t{Salary}\t{GetBonus()}");
        }

    }
}
