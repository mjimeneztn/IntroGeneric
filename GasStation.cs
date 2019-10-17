using System.Collections.Generic;
using System;

namespace stations {
    public class GasStation : IStation<GasVehicle>
    {
        public int Capacity { get; set; } = 3;

        public void Refuel(List<GasVehicle> vehicles)
        {
            if (vehicles.Count <= Capacity){
                foreach( var GasVehicle in vehicles)
                {
                    Console.WriteLine($"The {GasVehicle.Make} {GasVehicle.Model} has been refueled.");
                }
            } else {
                Console.WriteLine("Too many Vehicles are trying to be refueled.");
            }

        }
    }
}