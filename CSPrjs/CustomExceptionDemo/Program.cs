namespace CustomExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account account = new Account(5000);
                account.Deposit(1000);
                Console.WriteLine($"Amount deposited,current balance:{account.GetBalance()}");
                account.Withdraw(2000);
                Console.WriteLine($"Amount withdrawn,current balance:{account.GetBalance()}");
                account.Withdraw(6000);
                Console.WriteLine($"Amount withdrawn,current balance:{account.GetBalance()}");
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidDepositAmountException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank u for using our services");
            }
        }
    }

    class Account
    {
        int balance;
        public Account(int balance)
        {
            this.balance = balance;
        }
        public double GetBalance()
        {
            return balance;
        }
        public void Withdraw(int amount)
        {
            if(amount>balance)
            {
                //throw the exception
                throw new InsufficientFundsException("insufficient funds to withdraw!!!");
            }
            balance -= amount;
        }
        public void Deposit(int amount)
        {  
            if(amount<=0)
            {
                //throw the exception
                throw new InvalidDepositAmountException("Amount must be greater than 0");
            }
            balance += amount; 
        }
    }

    //define the exception
    public class InsufficientFundsException : ApplicationException
    {
        public InsufficientFundsException(string errMsg)
            :base(errMsg) 
        {
            
        }
    }
    public class InvalidDepositAmountException : ApplicationException
    {
        public InvalidDepositAmountException(string errMsg)
            :base(errMsg) 
        {
            
        }
    }
}
