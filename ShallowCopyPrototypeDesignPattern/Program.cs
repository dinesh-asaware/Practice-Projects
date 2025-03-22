using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowCopyPrototypeDesignPattern
{
    using System;

    class Person
    {
        public string Name { get; set; }
        public Address Address { get; set; }

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }
    }

    class Address
    {
        public string City { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Person original = new Person { Name = "Alice", Address = new Address { City = "New York" } };
            Person copy = original.ShallowCopy();

            Console.WriteLine(copy.Name); // Output: Alice
            Console.WriteLine(copy.Address.City); // Output: New York

            // Modify the address in the copied object
            copy.Address.City = "Los Angeles";

            // Both objects reflect the change because the Address object is shared
            Console.WriteLine(original.Address.City); // Output: Los Angeles
            Console.WriteLine(copy.Address.City); // Output: Los Angeles


            Console.ReadLine();
        }
    }

}
