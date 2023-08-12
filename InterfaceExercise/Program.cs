using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var kia = new Car();
            kia.Make = "KIA";
            kia.Model = "Optima";
            kia.Year = 2018;
            kia.CoName = "Hyundai Motor Company";
            kia.IsConvertible = false;
            kia.WheelCount = 4;

            var gmc = new Truck();
            gmc.Make = "GMC";
            gmc.Model = "Sierra";
            gmc.Year = 2015;
            gmc.BedSpace = 61;
            gmc.Torque = 460;
            gmc.CoName = "General Motors";

            var jeep = new SUV();
            jeep.Make = "Jeep";
            jeep.Model = "Grand Cherokee";
            jeep.Year = 2021;
            jeep.CargoHoldSize = 36;
            jeep.CoName = "Stellantis";

            var parkingLot = new List<IVehicle>() { kia, gmc, jeep };

            foreach(var vehicle in parkingLot)
            {
                if(vehicle is Car)
                {
                    Console.WriteLine($"Car's Make: {vehicle.Make} | Car's Model: {vehicle.Model} | Car's Year: {vehicle.Year}");
                }
                else if(vehicle is Truck)
                {
                    Console.WriteLine($"Truck's Make: {vehicle.Make} | Truck's Model: {vehicle.Model} | Truck's Year: {vehicle.Year}");
                }
                else if(vehicle is SUV)
                {
                    Console.WriteLine($"SUV's Make: {vehicle.Make} | SUV's Model: {vehicle.Model} | SUV's Year: {vehicle.Year}");
                }
            }

        }
    }
}
