namespace CalculatorAPI.Models
{
    public interface ICalculatorService
    {
        int Add(int n1, int n2);
        int Subtract(int n1, int n2);
        int Multiply(int n1, int n2);
        int Divide(int n1, int n2);

    }
}
