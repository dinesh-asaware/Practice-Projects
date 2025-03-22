using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponcibilityPrinciple
{
    public class SalaryCalculator
    {
        // Salary calculation logic
        public void CalculateSalary()
        {
            double salary = 10000;
            Console.WriteLine("Hello your Salary is : " + salary);
        }
    }

    public class ReportGenerator
    {
        // Report generation logic
        public void GenerateReport()
        {
            Console.WriteLine("Hello your report has been generated : ");
        }
    }

    public class EmolpyeeRepository
    {
        // Database saving logic
        public void SaveToDataBase()
        {
            Console.WriteLine("Hello you data has been saved successfully !!!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SalaryCalculator sc = new SalaryCalculator();
            sc.CalculateSalary();

            ReportGenerator rg = new ReportGenerator();
            rg.GenerateReport();

            EmolpyeeRepository er = new EmolpyeeRepository();
            er.SaveToDataBase();

            Console.ReadLine();
        }
    }
}
