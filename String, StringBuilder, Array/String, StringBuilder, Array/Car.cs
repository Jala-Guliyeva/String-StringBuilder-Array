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
            Console.WriteLine($"{color};{year};{Brand};{Model};{FuelCapacity};{FuelFor1Km};{CurrentFuel}" );
            

        }
        public void Drive()
        {
            double Carkm = 5;
           
            if (Carkm*FuelFor1Km < CurrentFuel)
            {
                Console.WriteLine($"Carlitr:{CurrentFuel - (Carkm * FuelFor1Km)}");
            }
            
            else 
            { 
                Console.WriteLine("gasoline is low");
            }


           

        

           
        }
        
    
    }
}
