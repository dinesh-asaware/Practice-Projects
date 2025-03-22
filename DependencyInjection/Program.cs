using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface IAccount
    {
        void PrintDetails();

    }

    public class CurrentAccount : IAccount
    {
        public void PrintDetails() 
        {
            Console.WriteLine("details of Current account ");
        }
    }

    public class SavingAccount : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("details of Saving account ");
        }
    }

    public class Account
    {
        public void AccountDetails(IAccount account)
        {
            account.PrintDetails();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account ca = new Account();
            ca.AccountDetails(new CurrentAccount());

            Account sa = new Account();
            sa.AccountDetails(new SavingAccount());

            Console.ReadLine();
        }
    }
}
