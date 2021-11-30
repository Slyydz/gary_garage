using System;

namespace gary_garage
{
    public class Tesla : Vehicle // Electric car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine("The red Tesla flys past.");
        }

        public override void Turn(string dir)
        {
            Console.WriteLine($"The Tesla quietly yanks {dir}");
        }

        public override void Stop()
        {
            Console.WriteLine($"The Tesla quietly halts");
        }
    }
}