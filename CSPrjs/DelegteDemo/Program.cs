namespace DelegteDemo
{
    internal class Program
    {
        delegate int MathsDelegate(int a, int b); //declare
        static void Main(string[] args)
        {
            int a = 100, b = 30;
            //bind the method
            MathsDelegate dlg = new MathsDelegate(Calculator.Add);
            //invoke
            int result = dlg(a, b);

            Console.WriteLine($"sum of {a} and {b} is {result}");

            dlg=new MathsDelegate(Calculator.Subtract);
            //Console.WriteLine($"Difference of {a} and {b} is {dlg(a,b)}");

            dlg += new MathsDelegate(Calculator.Multiply);

            Console.WriteLine(dlg(a, b));

            //bind the anonymous method
            dlg = new MathsDelegate(delegate (int a, int b) 
                                    { 
                                        return a / b;
                                    });

            result=dlg(a, b);
            Console.WriteLine($"Division of {a} and {b} is {result}");

            //lambda expression with delegate
            dlg = new MathsDelegate((a,b)=>{return a / b;});
            result = dlg(a, b);
            Console.WriteLine($"Division of {a} and {b} is {result}");

        }
    }

    class Calculator
    {
        public static int Add(int a,int b) { return a + b; }
        public static int Subtract(int a, int b) { return a - b; }
        
        public static int Multiply(int a,int b) { return a * b;}
    }
}
