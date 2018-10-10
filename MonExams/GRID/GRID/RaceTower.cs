using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRID
{
    public class RaceTower
    {
        private List<Driver> DriversLis;
        private List<Driver> RemovedDriverLis;
        public bool IsFinished { get; private set; }

        private int lapsNumber;
        private int trackLength;
        private int currlap;

        public RaceTower()
        {
            this.DriversLis = new List<Driver>();
            this.RemovedDriverLis = new List<Driver>();
            this.IsFinished=false;
        }
        public void SetTrackInfo(int lapsNumber, int trackLength)
        {
            this.lapsNumber = lapsNumber;
            this.trackLength = trackLength;
        }

        public void RegisterDriver(List<string> commandArgs)
        {
            string type = commandArgs[0];
            string name = commandArgs[1];
            int hp = int.Parse(commandArgs[2]);
            double fuelAmount = double.Parse(commandArgs[3]);
            string tyreType = commandArgs[4];
            double tyreHardness = double.Parse(commandArgs[5]);

            try
            {
                Tyre CurrTyre = CreateTyre(tyreType, tyreHardness, commandArgs);
                Car CurrCar = new Car(hp, fuelAmount, CurrTyre);
                Driver driver = CreateDriver(type, name, CurrCar);
                this.DriversLis.Add(driver);
            }
            catch (ArgumentException e)
            {
                string g = e.Message;
            }
            

        }
        private static Driver CreateDriver(string type,string name,Car CurrCar)
        {
            switch (type)
            {
                case "Endurance":
                    return new EnduranceDriver(name, CurrCar);
                case "Aggressive":
                    return new AggressiveDriver(name, CurrCar);
                default:
                    throw new ArgumentException();
            }
        }
        private  static Tyre CreateTyre(string tyreType,double tyreHardness, List<string> commandArgs) 
        {
            switch (tyreType)
            {
                case "Ultrasoft":
                    return new UltrasoftTyre(tyreHardness, double.Parse(commandArgs[6]));
                case "Hard":
                    return new HardTyre(tyreHardness);
                default:
                    throw new ArgumentException("NO tyre");
            }
        }

        public void DriverBoxes(List<string> commandArgs)
        {
            string reason = commandArgs[0];
            string name = commandArgs[1];
            Driver driver = this.DriversLis.First(se => se.Name == name);
            driver.TotalTime += 20;
            if (reason== "Refuel")
            {
                driver.Refuel(double.Parse(commandArgs[2]));
            }
            else
            {
                if(commandArgs[2]== "Ultrasoft")
                {
                    double grip = double.Parse(commandArgs[3]);
                    double hardnes = double.Parse(commandArgs[2]);
                    Tyre tyre = new UltrasoftTyre(hardnes, grip);
                    driver.ChangeTyre(tyre);
                }
                else
                {
                    double hardnes = double.Parse(commandArgs[2]);
                    Tyre tyre = new HardTyre(hardnes);
                    driver.ChangeTyre(tyre);
                }
            }
        }


        public string CompleteLaps(List<string> commandArgs)
        {
            var sb = new StringBuilder();
            int numOfLaps = int.Parse(commandArgs[0]);
            var re= this.lapsNumber - numOfLaps;

            if (re<0)
            {
                throw new ArgumentException($"There is no time! On lap {this.currlap}.");
            }
            for (int i = 0; i < numOfLaps; i++)
            {
                foreach (var driver in this.DriversLis)
                {
                    driver.CompleteLap(this.trackLength);
                }
                this.currlap++;
                List<Driver> leit = new List<Driver>();
                foreach (var driver in this.DriversLis)
                {
                    leit.Add(driver);
                }
                foreach (var driver in this.DriversLis)
                {
                    try
                    {
                        driver.Car.FuelAmount -= this.trackLength * driver.FuelConsumptionPerKm;
                        driver.Car.Tyre.Degradate();
                    }
                    catch (ArgumentException ex)
                    {
                        driver.FailReason = ex.Message;
                        Driver Curdriver = driver;
                        leit.Remove(driver);
                        this.RemovedDriverLis.Add(Curdriver);
                    }
                }
                this.DriversLis = leit;
            }

            if (this.lapsNumber == this.currlap)
            {
                this.IsFinished = true;
            }
            return sb.ToString().Trim();
        }

        public string GetLeaderboard()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Lap {this.currlap}/{this.lapsNumber}");
            int index = 1;
            foreach (var driver in this.DriversLis.OrderBy(se=>se.TotalTime))
            {
                sb.AppendLine($"{index} {driver.Name} {driver.TotalTime:f3}");
                index++;
            }
            int index2 = 1;

            foreach (var driver in this.RemovedDriverLis)
            {
                sb.AppendLine($"{index} {driver.Name} {driver.FailReason}");
                index2++;
            }
            return sb.ToString().Trim();
        }
        public void Finich()
        {
            Console.WriteLine($"{this.DriversLis.OrderBy(se=>se.TotalTime).First().Name} wins the race for {this.DriversLis.OrderBy(se => se.TotalTime).First().TotalTime:f3} seconds.");
        }
    }
}
