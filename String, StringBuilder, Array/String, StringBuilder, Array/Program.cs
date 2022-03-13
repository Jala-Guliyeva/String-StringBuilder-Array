using System;
using String__StringBuilder__Array;

namespace String__StringBuilder__Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Car info = new Car();
            info.year =2014;
            info.color ="pink";
            info.Brand = "BMW";
            info.Model = "M2";
            info.FuelCapacity = 13.7;
            info.FuelFor1Km =3.1;
            info.CurrentFuel =20;
            info.ShowInfo();
            info.Drive();


        }
    }
}
