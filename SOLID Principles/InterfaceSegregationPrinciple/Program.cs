using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public interface IWork
    {
        void Work();
    }

    public interface IEat
    {
        void Eat();

    }

    public class Human:IWork,IEat
    {
        public void Work() 
        {
            Console.WriteLine("Human is working");
        }
        public void Eat()
        {
            Console.WriteLine("Human can eat");
        }
    }

    public class Robot:IWork
    {
        public void Work()
        {
            Console.WriteLine("Robot can work");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Work();
            human.Eat();

            Robot robot = new Robot();
            robot.Work();

            Console.ReadLine();
        }
    }
}
