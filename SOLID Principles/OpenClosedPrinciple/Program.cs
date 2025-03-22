using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public abstract class DiscountStratergy
    {
       public abstract double CalculateSalary(double amount);
    }

    public class RegularCustomer : DiscountStratergy
    {
        public override double CalculateSalary(double amount)
        {
            return (amount * 0.1);
        }
    }

    public  class VIPcustomer : DiscountStratergy
    {
        public override double CalculateSalary(double amount)
        {
            return (amount * 0.5);
        }
    }

    public class DiscountCalculator
    {
        private readonly DiscountStratergy _discountStratergy;


        public DiscountCalculator(DiscountStratergy discountStratergy)
        {
            _discountStratergy = discountStratergy;
        }

        public double ApplyDiscount(double amount)
        {
            return _discountStratergy.CalculateSalary(amount);
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           DiscountCalculator rc = new DiscountCalculator(new RegularCustomer());

            Console.WriteLine(rc.ApplyDiscount(100));

            DiscountCalculator vc = new DiscountCalculator(new VIPcustomer());
            Console.WriteLine(vc.ApplyDiscount(100));

            Console.ReadLine();

        }
    }
}
