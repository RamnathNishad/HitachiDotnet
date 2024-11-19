namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1, n2, result;
                Console.Write("Enter n1:");
                n1 = int.Parse(Console.ReadLine());
                Console.Write("Enter n2:");
                n2 = int.Parse(Console.ReadLine());

                result = n1 / n2;
                Console.WriteLine("Result:" + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Some error occurred, try later");
                Logger.LogError(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }           
    }
}


//always handle specific exceptions rather than generic catch block
//define general exception as a last catch block in case any exception
//is missed out.
//never leave the catch block empty.
//always provide, user-friendly error msgs to end-user. 
//log the server-side errors in some log storage like files 
//and send user-define msgs to end-users.

