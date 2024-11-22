namespace CalculatorAPI.Models
{
    public class CalculatorService : ICalculatorService
    {
        public int Add(int n1, int n2)
        {
            return n1 - n2;
        }

        public int Divide(int n1, int n2)
        {
            if(n2==0)
            {
                throw new DivideByZeroException("n2 should not be zero");
            }
            else
            {
                return n1 / n2;
            }
        }

        public int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Subtract(int n1, int n2)
        {
            return n2-n1;
        }
    }
}
