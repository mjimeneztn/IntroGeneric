using System.Collections.Generic;
using System;

namespace stations {
    public class BatteryStation : IStation<ElectricVehicle>
    {
        public int Capacity {get;set;}= 4;

        public void Refuel(List<ElectricVehicle> vehicles)
        {
            if (vehicles.Count <= Capacity){
                foreach( var ElectricVehicle in vehicles)
                {
                    Console.WriteLine($"The {ElectricVehicle.Make} {ElectricVehicle.Model} has been charged.");
                }
            } else {
                Console.WriteLine("Too many Vehicles are trying to be charged.");
            }

        }
    }
}