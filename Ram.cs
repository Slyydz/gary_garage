using System;

namespace gary_garage
{
    public class Ram : Vehicle, IGasVehicles  // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; } = 32;
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
            Console.WriteLine("Tank refilled");
        }

        public override void Drive()
        {
            Console.WriteLine("The blue Ram flys past. RRrrrrrummbbble!");
        }
    }
}