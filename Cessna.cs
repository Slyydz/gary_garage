using System;

namespace gary_garage
{
    public class Cessna : Vehicle, IGasVehicles // Propellor light aircraft
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
            Console.WriteLine("The black Cessna flys past. RRrrrrrummbbble!");
        }

        public override void Turn(string dir)
        {
            Console.WriteLine($"The Cessna carefully banks {dir}");
        }

        public override void Stop()
        {
            Console.WriteLine($"The Cessna slowly halts to a stop on the runway.");
        }
    }


}