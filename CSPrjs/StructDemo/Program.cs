namespace StructDemo
{

    struct Address
    {
        public int Hno;
        public string City;
        public string State;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Address adr = new Address();
            adr.Hno = 101;
            adr.City = "Bangalore";
            adr.State = "KA";

            Console.WriteLine($"House no.:{adr.Hno}");
            Console.WriteLine($"City:{adr.City}");
            Console.WriteLine($"State:{adr.State}");
            Console.WriteLine("========================");

            Address adr2 = adr;
            adr2.Hno = 201;

            Console.WriteLine($"House no.:{adr.Hno}");
            Console.WriteLine($"City:{adr.City}");
            Console.WriteLine($"State:{adr.State}");
            Console.WriteLine("========================");
            Console.WriteLine($"House no.:{adr2.Hno}");
            Console.WriteLine($"City:{adr2.City}");
            Console.WriteLine($"State:{adr2.State}");
        }
    }
    //structure is a value-type as compared to class which is 
    //a reference type
    //-struct can have constructor but no destructor


}
