using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class ProviderFactory
    {
        public Provider CreateProvider(List<string> lis)
        {
            string type = lis[0];
            string id = lis[1];
            double energyOutput = double.Parse(lis[2]);
            switch (type)
            {
                case "Pressure":
                    return new PressureProvider(id, energyOutput);
                case "Solar":
                    return new SolarProvider(id, energyOutput);
                default:
                    throw new ArgumentException("Provider was not created");
            }
        }
    }

