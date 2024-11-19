namespace AbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape sh;

            sh = new Circle();
            sh.Area();
            sh.Perimeter();
            sh.FillShape();

            sh = new Square();
            sh.Area();
            sh.Perimeter();
            sh.FillShape();
        }
    }

    abstract class Shape
    {
        public abstract void Area();
        public abstract void Perimeter();
        public void FillShape()
        {
            Console.WriteLine("Fill Color");
        }
    }

    class Square : Shape
    {
        public override void Area()
        {
            Console.WriteLine("Area of Square");
        }

        public override void Perimeter()
        {
            Console.WriteLine("Perimeter of Square");
        }
    }

    class Circle : Shape
    {
        public override void Area()
        {
            Console.WriteLine("Area of Circle");
        }

        public override void Perimeter()
        {
            Console.WriteLine("Perimeter of Circle");
        }
    }
    //area()
    //perimeter()
    //fillColor(){}
}
