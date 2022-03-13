using System;
using System.Collections.Generic;
using System.Text;

namespace String__StringBuilder__Array
{
    public class Car:Vehicle
    {
        public string Brand;
        public string Model;
        public double FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;
      


        public void ShowInfo()
        {
            Console.WriteLine($"Color:{color},Year:{year},Brand:{Brand},Model:{Model},FuelCapacity:{FuelCapacity},FuelFor1km:{FuelFor1Km},CurrentFuel:{CurrentFuel}" );
            

        }
        public void Drive()
        {
            double Carkm;
            double Outcome;

            Console.Write("How many kilometers will it take?:");
            Carkm = Convert.ToInt32(Console.ReadLine());
            Outcome = CurrentFuel - (Carkm * FuelFor1Km);

            if (Outcome>0)
            {
                Console.WriteLine($"Remaining in the fuel:{Outcome}");
            }
            else
            {
                Console.WriteLine("please refuel");
            }
            







        }
        
    
    }
}
