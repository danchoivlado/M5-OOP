using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRID
{
    public class Car
    {
        public int Hp { get; set; }
        private double fuelAmount;
        public Tyre Tyre { get; private set; }

        public Car(int hp, double fuelAmount, Tyre tyre)
        {
            this.Hp = hp;
            this.FuelAmount = fuelAmount;
            this.Tyre = tyre;
        }
        public void Refuel(double ammount)
        {
            this.FuelAmount += ammount;
        }
        public double FuelAmount
        {
            get { return fuelAmount; }
            set
            {
                if (value < 0) throw new ArgumentException("Out of fuel");
                    fuelAmount = Math.Min(value, 160);
            }
        }
        public void ChnageTyre(Tyre tyre)
        {
            this.Tyre = tyre;
        }
        public void ReduceFuel(double fuel)
        {
            this.FuelAmount -= fuel;
        }
    }
}
