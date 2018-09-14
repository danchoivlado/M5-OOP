using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class HarvesterFactory
    {
        public Harvester CreateHarvester(List<string> lis)
        {
            string type = lis[0];
            string id = lis[1];
            double oreOutput = double.Parse(lis[2]);
            double energyRequirement = double.Parse(lis[3]);
            switch (type)
            {
                case "Sonic":
                    return new SonicHarvester(id, oreOutput, energyRequirement, int.Parse(lis[4]));
                case "Hammer":
                    return new HammerHarvester(id, oreOutput, energyRequirement);
                default:
                    throw new ArgumentException("HarvesterNotCreated");
            }

        }
    }

