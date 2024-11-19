namespace DictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> books = new Dictionary<int,string>();

            books.Add(1001, "Learning C#");
            books.Add(1002, "ASP.NET Tutorials");
            books.Add(1003, "Sql Server for Beginners");
            //if (books.ContainsKey(1003))
            //{
            //    Console.WriteLine(books[1003]);
            //}
            //else
            //{
            //    Console.WriteLine("Book id not present");
            //}

            foreach (var k in books.Keys)
            {
                Console.WriteLine($"Book id:{k}\tBook name:{books[k]}");
            }
            Console.WriteLine("\nTraverse values");
            foreach(var v in books.Values)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("\nTraverse using KeyValuePair");
            foreach(var kv in books)
            {
                var k = kv.Key;
                var v= kv.Value;
                Console.WriteLine(k + ":" + v);
            }
        }
    }
}
