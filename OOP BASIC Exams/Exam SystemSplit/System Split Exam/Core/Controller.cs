using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Controller
    {
        private List<Hardware> HardwereComponentsLis;
        


        public Controller()
        {
            this.HardwereComponentsLis = new List<Hardware>();
        }
        public void DumpTo(string[] arr)
        {
            string hardwareComponentName = arr[1];
            Hardware CurrHardware = this.HardwereComponentsLis.FirstOrDefault(se => se.Name == hardwareComponentName);
            if (CurrHardware != null)
            {
                Dump.AddToDump(CurrHardware);
                this.HardwereComponentsLis.Remove(CurrHardware);
            }
            
        }
        public void Restore(string[] arr)
        {
            string hardwareComponentName = arr[1];
            Hardware Curhardware= Dump.Restore(hardwareComponentName);
            if (Curhardware != null)
            {
                this.HardwereComponentsLis.Add(Curhardware);
            }
        }
        public void Destroy(string[] arr)
        {
            string hardwareComponentName = arr[1];
            Dump.Destroy(hardwareComponentName);
        }
        public void RegisterPowerHardware(string[] arr)
        {
            string name = arr[1];
            int cap = int.Parse(arr[2]);
            int mem = int.Parse(arr[3]);
            this.HardwereComponentsLis.Add(new PowerHardware(name, cap, mem));
        }
        public void RegisterHeavyHardware(string[] arr)
        {
            string name = arr[1];
            int cap = int.Parse(arr[2]);
            int mem = int.Parse(arr[3]);
            this.HardwereComponentsLis.Add(new HeavyHardware(name, cap, mem));
        }
        public void RegisterExpressSoftware(string[] arr)
        {
            string hardwareComponentName = arr[1];
            string name = arr[2];
            int cap = int.Parse(arr[3]);
            int mem = int.Parse(arr[4]);

            Hardware CurrHardware = this.HardwereComponentsLis.FirstOrDefault(se => se.Name == hardwareComponentName);

            if (CurrHardware != null)
            {
                Software software = new ExpressSoftware(name, cap, mem);
                bool passed =CurrHardware.AddSoftwere(software);
                
            }
        }
        public void RegisterLightSoftware(string[] arr)
        {
            string hardwareComponentName = arr[1];
            string name = arr[2];
            int cap = int.Parse(arr[3]);
            int mem = int.Parse(arr[4]);

            Hardware CurrHardware = this.HardwereComponentsLis.FirstOrDefault(se => se.Name == hardwareComponentName);

            if (CurrHardware != null)
            {
                Software software = new LightSoftware(name, cap, mem);
                bool pass= CurrHardware.AddSoftwere(software);
               
            }
        }
        public void ReleaseSoftwareComponent(string[] arr)
        {
            string hardwareComponentName = arr[1];
            string softwareComponentName = arr[2];

            Hardware CurrHardware = this.HardwereComponentsLis.FirstOrDefault(se => se.Name == hardwareComponentName);
            Software CurrSoftware = CurrHardware.FindSoftware(softwareComponentName);
            bool Validate = CurrHardware is null || CurrSoftware is null;
            if (Validate is false)
            {
                CurrHardware.DeleteSoftware(CurrSoftware);
            }
        }
        public string Analyze()

        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"System Analysis");
            sb.AppendLine($"Hardware Components: {this.HardwereComponentsLis.Count}");
            sb.AppendLine($"Software Components: {this.HardwereComponentsLis.Sum(se=>se.AllSoftwereSum())}");
            sb.AppendLine($"Total Operational Memory: {this.HardwereComponentsLis.Sum(se => se.CurMem)} / {this.HardwereComponentsLis.Sum(se => se.MaxMemory)}");
            sb.AppendLine($"Total Capacity Taken: {this.HardwereComponentsLis.Sum(se => se.CurCapacity)} / {this.HardwereComponentsLis.Sum(se => se.MaxCapacity)}");
            return sb.ToString().Trim();

        }
        public string SystemSplit()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var comp in HardwereComponentsLis)
            {
                sb.AppendLine($"Hardware Component - {comp.Name}");
                sb.AppendLine($"Express Software Components - {comp.CountOfExpressSoftwareComponents()}");
                sb.AppendLine($"Light Software Components - {comp.CountOfLightSoftwareComponents()}");
                sb.AppendLine($"Memory Usage: {comp.CurMem} / {comp.MaxMemory}");
                sb.AppendLine($"Capacity Usage: {comp.CurCapacity} / {comp.MaxCapacity}");
                sb.AppendLine($"Type: {comp.Type.Substring(0, 5)}");
                sb.AppendLine($"Software Components: {comp.Join()}");
            }
            return sb.ToString().Trim();
        }
    }

