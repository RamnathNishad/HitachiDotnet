namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape sh; //should not create instance of it

            sh = new Circle();
            sh.Area();
            sh.Perimeter();

            sh = new Square();
            sh.Area();
            sh.Perimeter();
        }
    }


    interface IShape
    {
        void Area();
        void Perimeter();
    }

    class Circle : IShape
    {
        public void Area()
        {
            Console.WriteLine("Area of Circle");
        }
        public void Perimeter()
        {
            Console.WriteLine("Perimeter of Circle");
        }
    }
    class Square : IShape
    {
        public void Area()
        {
            Console.WriteLine("Area of Square");
        }

        public void Perimeter()
        {
            Console.WriteLine("Perimeter of Square");
        }
    }
}
