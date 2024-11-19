namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            int y = 5;
            Console.WriteLine($"square of {x} is {x.Square()}");

            int res=x.DivideBy(y);
            Console.WriteLine(res);

            string s = "Welcome";
            Console.WriteLine(s.NoOfChars());

            Customer customer = new Customer();
            customer.Login("admin", "123");
        }


    }

    static class ExtCls
    {
        public static int Square(this int n)
        {
            return n * n;
        }
        public static int DivideBy(this int n, int y)
        {
            return n / y;
        }
        public static int NoOfChars(this string s)
        {
            return s.Length;
        }
        public static void Login(this Customer customer,string username,string password)
        {
            //TODO
        }
    }


    class Customer
    {
        public void Register()
        {
            //
        }
    }
}
