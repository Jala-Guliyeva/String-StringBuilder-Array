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
        //public double Carkm;


        public void ShowInfo()
        {
            Console.WriteLine($"{color};{year};{Brand};{Model};{FuelCapacity};{FuelFor1Km};{CurrentFuel}" );
            

        }
        public void Drive()
        {
            int Carkm = 5;
           
            if (Carkm < CurrentFuel)
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
