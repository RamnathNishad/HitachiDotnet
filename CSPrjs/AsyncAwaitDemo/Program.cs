namespace AsyncAwaitDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting download...");
            string content = await DownloadData("http://google.com");
            Console.WriteLine(content.Substring(0,200));
        }

        static async Task<string> DownloadData(string url)
        {
            HttpClient client = new HttpClient();
            string result=await client.GetStringAsync(url);
            return result;
        }
    }
}
