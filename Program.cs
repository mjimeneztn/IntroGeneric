using System;
using System.Collections.Generic;

namespace stations
{
    class Program
    {
        static void Main(string[] args)
        {
          List<ElectricVehicle> electricVehicles = new List<ElectricVehicle>() {
                new ElectricVehicle(){  Make = "Nissan", Model= "Leaf"},
                new ElectricVehicle(){  Make = "Telsa", Model= "Model X"},
                new ElectricVehicle(){ Make = "Chevrolet", Model= "Bolt"},
                new ElectricVehicle(){  Make = "Fiat", Model= "500"},

            };
             BatteryStation BatteryStation = new BatteryStation();
             BatteryStation.Refuel(electricVehicles);

          List<GasVehicle> gasVehicles = new List<GasVehicle>() {
                new GasVehicle(){  Make = "Honda", Model= "Accord"},
                new GasVehicle(){  Make = "Dodge", Model= "Ram"},
                new GasVehicle(){ Make = "Toyota", Model= "Corolla"},
                new GasVehicle(){  Make = "Nissan", Model= "Versa"},

            };
             GasStation gasStation = new GasStation();
             gasStation.Refuel(gasVehicles);

        }
    }
}
