namespace WebAPIConsoleClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (var client=new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5162/api/Employees/");

                var response = await client.GetStringAsync("GetEmps");
                
                Console.WriteLine(response);
            }
        }
    }
}
