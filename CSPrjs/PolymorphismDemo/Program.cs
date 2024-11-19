namespace PolymorphismDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare to base type only to have dynamic polymorphism
            //using overriding.
            Parent p;

            p = new Parent(10);
            p.Show();

            p = new Child1(10,20);
            p.Show();

            p = new Child2(10,30);
            p.Show();

        }
    }
    class Parent
    {
        int p;
        public Parent(int p)
        {
            this.p = p;
        }
        public virtual void Show()
        {
            Console.WriteLine($"Parent.Show-->{this.p}");
        }
    }
    class Child1: Parent
    {
        int c1;
        public Child1(int p,int c1): base(p)
        {
            this.c1 = c1;   
        }
        public override void Show()
        {
            Console.WriteLine($"Child1.Show-->{this.c1}");
        }
    }
    class Child2 : Parent
    {
        int c2;
        public Child2(int p,int c2) : base(p)
        {
            this.c2 = c2;
        }
        public override void Show()
        {
            Console.WriteLine($"Child2.Show--->{this.c2}");
        }
    }
}
