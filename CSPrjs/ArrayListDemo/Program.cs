using System.Collections;

namespace ArrayListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrLst=new ArrayList();

            arrLst.Add(101);
            arrLst.Add(102);
            arrLst.Add("Hello");
            arrLst.Add(104);
            arrLst.Add(105);

            foreach (var o in arrLst)
            {
                if (o is int)
                {
                    int intVal = (int)o;
                    Console.WriteLine(intVal);
                }
                else if (o is string)
                {
                    string strVal = (string)o;
                    Console.WriteLine(strVal);
                }
            }

        }
    }
}
