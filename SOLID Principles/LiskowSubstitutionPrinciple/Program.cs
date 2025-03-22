using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskowSubstitutionPrinciple
{
    public interface IFruit
    {
        void GetColor();

    }
    public class Apple:IFruit
    {
        public void GetColor()
        {
            Console.WriteLine("color of Apple is red");
        }
    }

    public class Orange: IFruit
    {
        public void GetColor()
        {
                Console.WriteLine("color of Orange is yellow");
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            IFruit apple = new Apple();

            apple.GetColor();

            IFruit orange = new Orange();
            orange.GetColor();

            Console.ReadLine();
        }
    }
}
