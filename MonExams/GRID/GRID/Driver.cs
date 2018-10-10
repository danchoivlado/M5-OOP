using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRID
{
    public abstract class Driver
    {
        public string Name { get; }
        public double TotalTime { get; set; }
        public Car Car { get; }
        public double FuelConsumptionPerKm { get; }
        public virtual double Speed => (this.Car.Hp + this.Car.Tyre.Degradation) / this.Car.FuelAmount;
        public string FailReason { get; set; }
        protected Driver(string name, Car car, double fuelConsumptionPerKm)
        {
            this.Name = name;
            this.Car = car;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }
        public void Refuel(double ammount)
        {
            this.Car.Refuel(ammount);
        }
        public void ChangeTyre(Tyre tyre)
        {
            this.Car.ChnageTyre(tyre);
        }
        public void CompleteLap(int tracklenght)
        {
            this.TotalTime += 60 / (tracklenght / this.Speed);
        }
        public void ReduceFuel(double fuel)
        {
            this.Car.ReduceFuel(fuel);
        }
    }
}
