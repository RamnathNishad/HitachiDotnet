namespace CallbackAndDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jobs jobs = new Jobs();
            jobs.StartJob1();

        }
    }

    class Jobs
    {
        public void StartJob1()
        {
            Job1.dlg=new Job1.MsgDelegate(this.Notify);
            Job1.SomeTask();
        }
        void Notify(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    class Job1
    {
        public delegate void MsgDelegate(string msg);
        public static MsgDelegate dlg = null;
        public static void SomeTask()
        {
            Console.WriteLine("Task is initiated");
            System.Threading.Thread.Sleep(5000);
            //notify to the caller task is over
            string msg = "Task is completed";
            //call private notify method of parent 
            dlg(msg);
        }
    }
}
