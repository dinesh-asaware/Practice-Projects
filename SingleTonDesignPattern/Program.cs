using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonDesignPattern
{
    public class Singleton
    {
        private static Singleton instance;
        private static readonly object lockObj = new object();

        private Singleton() 
        {
        
        }

        public static Singleton GetInstance()
        {
            lock (lockObj)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
            }
            return instance;
        }

        public void ShowMessageOne()
        {
            Console.WriteLine("you have created only one object!");
        }

        public void ShowMessageTwo()
        {
            Console.WriteLine("you do not allowed to create second time object!");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {

            Singleton obj1 = Singleton.GetInstance();
            obj1.ShowMessageOne();
            Singleton obj2 = Singleton.GetInstance();
            obj2.ShowMessageTwo();

            Console.ReadLine();
        }
    }

}
