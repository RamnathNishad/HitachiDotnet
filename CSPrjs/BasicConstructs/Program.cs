namespace BasicConstructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.ADD");
            Console.WriteLine("2.SUBTRACT");
            Console.WriteLine("3.MULTIPLY");
            Console.WriteLine("4.DIVIDE");
            Console.Write("Enter choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            int n1, n2, result;
            Console.Write("Enter n1:");
            n1= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter n2:");
            n2= Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case (int)MenuChoice.ADD:
                    result = n1 + n2;
                    Console.WriteLine("Sum:"+result);
                    break;
                case (int)MenuChoice.SUBTRACT:
                    result = n1 - n2;
                    Console.WriteLine("Difference:" + result);
                    break;
                case (int)MenuChoice.MULTIPLY:
                    result = n1 * n2;
                    Console.WriteLine("Product:" + result);
                    break;
                case (int)MenuChoice.DIVIDE:
                    result = n1 / n2;
                    Console.WriteLine("Divsion:" + result);
                    break;
            }
        }
    }
}
