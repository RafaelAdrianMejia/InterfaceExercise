﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */
        public int BedSpace { get; set; }
        public int Torque { get; set; }
        public string Make { get ; set ; }
        public string Model { get ; set ; }
        public int Year { get ; set ; }
        public int WheelCount { get ; set ; }
        public string Logo { get ; set ; }
        public string CoName { get ; set ; }
    }
}
