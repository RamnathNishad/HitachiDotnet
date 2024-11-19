using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    internal class Logger
    {
        public static void LogError(Exception ex)
        {
            //log the msg into file
            string dt=DateTime.Now.ToString("dd:MM:yyyy hh:mm:ss");
            File.AppendAllText("d:\\error_log.txt",$"Error:{dt}, {ex.StackTrace}");
        }
    }
}
