using System;
using System.Collections.Generic;

namespace gary_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Cessna plane = new Cessna();
            Zero fx = new Zero();
            Tesla models = new Tesla();
            Ram truck = new Ram();


            plane.Drive();
            plane.Turn("Left");
            plane.Stop();
            Console.WriteLine();

            fx.Drive();
            fx.Turn("Right");
            fx.Stop();
            Console.WriteLine();

            models.Drive();
            models.Turn("Left");
            models.Stop();
            Console.WriteLine();

            truck.Drive();
            truck.Turn("Right");
            truck.Stop();
            Console.WriteLine();
        }
    }
}
