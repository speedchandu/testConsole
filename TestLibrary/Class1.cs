using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class Test
    {
        private static int i = 10;
        
        private int j=10;
        public static int TestFunction()
        {
            return i;
        }

        public int TestNonStatic()
        {
            i++;
            j++;
            //line of codes
            
            return j;
        }
    }

    public abstract class Vehicle
    {
        public abstract void Run();

        public abstract void NumberofTyres();

        
    }

    public class Car : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("This is car. Runs on petrol, 4 wheel");
        }

        public override void NumberofTyres()
        {
            Console.WriteLine("4 tyres");
        }

        
    }

    public class Bus : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("This is bus. Runs on Diesel,4 wheeler");
        }
        public override void NumberofTyres()
        {
            Console.WriteLine("6 tyres");
        }
    }

    public class Bike : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("This is bike. 2 wheeler");
        }
        public override void NumberofTyres()
        {
            Console.WriteLine("2 tyres");
        }
        public void Steer()
        {
            Console.WriteLine("Handle");
        }
    }

    


}
