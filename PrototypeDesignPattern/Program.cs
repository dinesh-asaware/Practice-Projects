using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{

    public interface IPrototype
    {
        IPrototype Clone();
    }

    //Implement the Clone method to return a deep copy of the object.

    public class Employee: IPrototype
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public Employee(string name,string department)
        {
            Name = name;
            Department = department;
            
        }

        // Clone method

        public IPrototype Clone()
        {
            return new Employee(this.Name, this.Department);
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Employee : {Name} , Department : { Department }");
        }
    }

        // The client uses the prototype to create new objects.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a prototype object

            Employee emp1 = new Employee("Dinesh","IT");
            emp1.ShowDetails();

            // Clone the object

            Employee emp2 = (Employee)emp1.Clone();
            emp2.Name = "Priya";  // Modify cloned object
            
            emp2.ShowDetails();

            Console.ReadLine();
        }
    }
}
