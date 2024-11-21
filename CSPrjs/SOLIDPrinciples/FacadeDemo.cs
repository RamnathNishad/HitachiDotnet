using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    internal class FacadeDemo
    {
        public void GetReport() //facade layer 
        {
            Account account = new Account();
            account.CreateAnnualReport();

            ReportPrinter printer = new ReportPrinter();
            printer.PrintReport();
        }
    }

    class Account
    {
        public void CreateAnnualReport()
        {
            Console.WriteLine("Annual Report created");
        }
    }

    class ReportPrinter
    {
        public void PrintReport()
        {
            Console.WriteLine("Report is printed");
        }
    }
}
