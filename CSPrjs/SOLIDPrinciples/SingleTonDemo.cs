using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    internal class SingleTonDemo
    {
        static App instance;
        public static App CreateInstance()
        {
            //make sure that only one instance of App is created
            if(instance == null)
            {
                //for the first time
                instance = new App();
            }
            return instance;  //for next request onward, same instance is given  
        }
    }

    class App
    {
        public void Show() { }
    }
}
