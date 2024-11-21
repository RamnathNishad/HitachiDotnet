using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    //Liskov Substitution Principle
    internal class LSPPrinciple
    {
        public void Display()
        {
            Hyudai hyudai = new Hyudai(100);
            hyudai.Display();
            hyudai = new HyundaiPlus(150);
            hyudai.Display();
        }
    }

    class Hyudai
    {
        int maxSpeed;
        public Hyudai(int maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }
        public Hyudai()
        {
            
        }
        public virtual void Display()
        {
            Console.WriteLine("Hyundai maxspeed:"+maxSpeed);
        }

    }
    class HyundaiPlus : Hyudai
    {
        int maxSpeed;
        public HyundaiPlus(int maxSpeed) : base(100)
        {
            this.maxSpeed=maxSpeed;
        }
        public override void Display()
        {
            Console.WriteLine("HyundaiPlus maxSpeed:"+maxSpeed);
        }
    }
}
