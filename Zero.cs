using System;

namespace gary_garage
{
    public class Zero : Vehicle, IElectricVehicles // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage { get; set; } = 15;

        public void ChargeBattery()
        {
            // method definition omitted
            CurrentChargePercentage = 100;
            Console.WriteLine("Vehicle Recharged");
        }

        public override void Drive()
        {
            Console.WriteLine("The Grey Zero flys past. RRrrrrrummbbble!");
        }
    }
}