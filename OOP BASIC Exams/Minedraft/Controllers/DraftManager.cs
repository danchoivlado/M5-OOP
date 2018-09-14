
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class DraftManager
    {
        private List<Provider> providers;
        private List<Harvester> harvesters;
        private HarvesterFactory HarvesterFactory;
        private ProviderFactory ProviderFactory;
        private string mode;
        private double stotredEnergy;
        private double storedOre;

        public DraftManager()
        {
            this.providers = new List<Provider>();
            this.harvesters = new List<Harvester>();
            this.HarvesterFactory = new HarvesterFactory();
            this.ProviderFactory = new ProviderFactory();
            this.mode = "Full";
        }

        public string RegisterHarvester(List<string> arguments)
        {
            try
            {
                var harvester = this.HarvesterFactory.CreateHarvester(arguments);
                harvesters.Add(harvester);
                return $"Successfully registered {arguments[0]} Harvester - {harvester.Id}";

            }
            catch (ArgumentException ex)
            {
                return ex.Message;
            }

        }
        public string RegisterProvider(List<string> arguments)
        {
            try
            {
                var provider = this.ProviderFactory.CreateProvider(arguments);
                this.providers.Add(provider);
                return $"Successfully registered {arguments[0]} Provider - {provider.Id}";
            }
            catch (ArgumentException ex)
            {
                return ex.Message;
            }
        }
        public string Day()
        {
            var providedEnergy = providers.Sum(en => en.EnergyOutput);
            var neededEnergy = harvesters.Sum(need => need.EnergyRequirement);
            var oreOut = harvesters.Sum(ore => ore.OreOutput);
            this.stotredEnergy += providedEnergy;

            if (this.mode == "Half")
            {
                neededEnergy *= 0.6;
                oreOut *= 0.5;
            }

            if (mode=="Energy"||neededEnergy>stotredEnergy)
            {
                //oreOut = 0;
                return $"A day has passed." +Environment.NewLine+
                      $"Energy Provided: {providedEnergy}"+Environment.NewLine +
                      $"Plumbus Ore Mined: {0}";
            }

            this.stotredEnergy -= neededEnergy;
            this.storedOre += oreOut;

            return $"A day has passed." +Environment.NewLine+
                      $"Energy Provided: {providedEnergy}"+Environment.NewLine +
                      $"Plumbus Ore Mined: {oreOut}";

        }
        public string Mode(List<string> arguments)
        {
            this.mode = arguments[0];
            return $"Successfully changed working mode to {this.mode} Mode";
        }
        public string Check(List<string> arguments)
        {
            string id = arguments.First();
            foreach (var har in harvesters)
            {
                if (har.Id==id)
                {
                    return har.ToString();
                }
            }
            foreach (var provider in providers)
            {
                if (provider.Id==id)
                {
                    return provider.ToString();
                }
            }
            return $"No element found with id - {id}";
        }
        public string ShutDown()
        {
            return $"System Shutdown" + Environment.NewLine +
            $"Total Energy Stored: {this.stotredEnergy}" + Environment.NewLine +
            $"Total Mined Plumbus Ore: {this.storedOre}";
        }


    }

