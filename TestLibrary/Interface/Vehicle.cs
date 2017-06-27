using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary.Interface
{
    public interface Vehicles
    {
        void PrintVal();

    }

    public interface Vehicle1
    {
        void PrintData();
    }

    public interface TestInterface
    {
        void test();
    }
    public interface Common
    {
        void run(int i);
    }
    public class car : Vehicles,Vehicle1,Common
    {
        public void PrintVal()
        {
            Console.WriteLine("Vehile  interface -> car");
        }
        public void PrintData()
        {
            Console.WriteLine("Vehicle1 interface -> car");
        }

        public void run(int i)
        {
            Console.WriteLine("Run the car "+i);
        }
    }

    public class Bike :Vehicles,TestInterface,Common
    {
        public void PrintVal()
        {
            Console.WriteLine("Vehile  interface -> Bike");
        }
         public void test()
        {
            Console.WriteLine("Direct test from Bike interfaced with Vehicle.");
        }
        public void run(int i)
        {
            Console.WriteLine("Run the Bike "+i);
        }
    }

    public class Bus : Vehicle1,TestInterface,Common
    {
        public void PrintData()
        {
            Console.WriteLine("Vehicle1 interface -> Bus");
        }

        public void test()
        {
            Console.WriteLine("Direct test from Bus interfaced with Vehicle.");
        }
        public void run(int i)
        {
            Console.WriteLine("Run the Bus "+i);
        }
    }
}
