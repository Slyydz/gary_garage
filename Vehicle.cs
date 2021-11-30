using System;

namespace gary_garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vroom!");
        }

        public virtual void Turn(string dir)
        {
            Console.WriteLine($"The vehicle carefully turns {dir}");
        }

        public virtual void Stop()
        {
            Console.WriteLine("The vehicle slams to a stop");
        }
    }
}