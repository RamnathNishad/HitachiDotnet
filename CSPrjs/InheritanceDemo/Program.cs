namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContractualEmployee contractual = new ContractualEmployee(101, "Rahul", 50000);
            contractual.Display();

            PermanentEmployee permanent = new PermanentEmployee(102, "David", 70000);
            permanent.Display();

        }
    }
}
// Bird ---Fly()
// Crow :Bird
// Pigeon : Bird
