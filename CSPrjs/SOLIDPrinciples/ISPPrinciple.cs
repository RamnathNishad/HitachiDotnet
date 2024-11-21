using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    internal class ISPPrinciple
    {
    }

    interface IEmployee
    {
        void Register();
    }

    interface IManager : IEmployee
    {
        void DesignProject();
        void SetTarget();
    }
    interface IAccountant : IEmployee
    {
        void TaxFiling();
    }  

    class Manager : IManager
    {
        public void DesignProject()
        {
            throw new NotImplementedException();
        }        

        public void Register()
        {
            throw new NotImplementedException();
        }

        public void SetTarget() { }
    }
    class Accountant : IAccountant
    {
        public void Register()
        {
            throw new NotImplementedException();
        }

        public void TaxFiling() { }
    }
}
