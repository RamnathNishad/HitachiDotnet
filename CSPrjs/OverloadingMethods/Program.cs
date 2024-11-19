namespace OverloadingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(100,200));
            Console.WriteLine(Add(100,200,300));
            Console.WriteLine(Add(10.4,11.3));
        }

        static int Add(int n1,int n2)
        {
            return n1+ n2;
        }
        static int Add(int n1,int n2,int n3)
        {
            return n1 + n2 + n3;
        }
        static double Add(double n1,double n2)
        {
            return n1 + n2;
        }
    }


}
