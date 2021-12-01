using System;

namespace gary_garage
{
    public interface IGasVehicles
    {
        double FuelCapacity { get; }
        double CurrentTankPercentage { get; }
        void RefuelTank();

    }

    public interface IElectricVehicles
    {
        double BatteryKWh { get; }
        double CurrentChargePercentage { get; }
        void ChargeBattery();
    }
}