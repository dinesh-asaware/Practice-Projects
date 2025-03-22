using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopyPrototypeDesignPattern
{
    using System;

          //Implementing ICloneable for Manual Deep Copy
          //Manually implementing cloning allows for better control.

          //Example using ICloneable
    public class Person : ICloneable
    {
        public string Name { get; set; }
        public Address Address { get; set; }

        public object Clone()
        {
            return new Person
            {
                Name = this.Name,
                Address = new Address { City = this.Address.City }
            };
        }
    }

    public class Address
    {
        public string City { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Person original = new Person { Name = "John", Address = new Address { City = "New York" } };
            Person copy = (Person)original.Clone();

            copy.Name = "Jane";
            copy.Address.City = "Los Angeles";

            Console.WriteLine(original.Name);        // Output: John
            Console.WriteLine(original.Address.City); // Output: New York

            Console.WriteLine(copy.Name);        // Output: Jane
            Console.WriteLine(copy.Address.City); // Output: Los Angeles

            Console.ReadLine();
        }
    }

}
