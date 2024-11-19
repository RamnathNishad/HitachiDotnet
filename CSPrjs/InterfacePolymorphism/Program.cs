namespace InterfacePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount;
            double rate;
            int years;

            Console.WriteLine("1.SimpleInterest\n2.CompoundInterest");
            Console.Write("Enter choice:");
            int choice=int.Parse(Console.ReadLine());

            Console.Write("Enter amount:");
            amount = int.Parse(Console.ReadLine());
            Console.Write("Enter rate of interest:");
            rate = double.Parse(Console.ReadLine());
            Console.Write("Enter years:");
            years = int.Parse(Console.ReadLine());

            IInterestCalculator calc;
            if(choice==1)
            {
                calc = new SimpleInterest();
                Console.WriteLine("SI:" + calc.CalculateInterest(amount,rate,years));
            }
            else
            {
                calc = new CompoundInterest();
                Console.WriteLine("CI:" + calc.CalculateInterest(amount, rate, years));
            }
        }       
    }

    interface IInterestCalculator
    {
        double CalculateInterest(int amount,double rate,int years);
    }
    class SimpleInterest : IInterestCalculator
    {
        public double CalculateInterest(int amount, double rate, int years)
        {
            return amount * rate * years * 0.01;
        }
    }
    class CompoundInterest : IInterestCalculator
    {
        public double CalculateInterest(int amount, double rate, int years)
        {
            return amount*Math.Pow((1 + rate * 0.01), years)-amount;
        }
    }
}
//only one class can be inherited whether it is an abstract or
//non-abstract class but multiple interfaces can be implemented.

//virtual---optional overriding at derived level
//abstract--mandatory overriding at derived level

