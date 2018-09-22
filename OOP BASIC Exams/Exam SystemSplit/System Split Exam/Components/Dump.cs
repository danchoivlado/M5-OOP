using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public static class Dump 
    {
        private static List<Hardware> DumpedHardwares; 

        static Dump()
        {
            DumpedHardwares = new List<Hardware>();
        }

        public static void Destroy(string hardwareComponentName)
        {
            Hardware CurHardware = DumpedHardwares.FirstOrDefault(se=>se.Name==hardwareComponentName);
            DumpedHardwares.Remove(CurHardware);
        }

        public static Hardware Restore(string hardwareComponentName)
        {
            return DumpedHardwares.FirstOrDefault(se => se.Name == hardwareComponentName);
        }

        public static void AddToDump(Hardware hardware)
        {
            DumpedHardwares.Add(hardware);
        }
        public static string DumpAnalyze()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Dump Analysis");
            sb.AppendLine($"Power Hardware Components: {DumpedHardwares.Where(se=>se.Type == "PowerHardware").Count()}");
            sb.AppendLine($"Heavy Hardware Components: {DumpedHardwares.Where(se => se.Type == "HeavyHardware").Count()}");
            sb.AppendLine($"Express Software Components: {DumpedHardwares.Sum(se=>se.SeeSoftwareType("ExpressSoftware"))}");
            sb.AppendLine($"Light Software Components: {DumpedHardwares.Sum(se => se.SeeSoftwareType("LightSoftware"))}");
            sb.AppendLine($"Total Dumped Memory: {DumpedHardwares.Sum(se => se.CurMem)}");
            sb.AppendLine($"Total Dumped Capacity: {DumpedHardwares.Sum(se => se.CurCapacity)}");
            return sb.ToString().Trim();
        }
    }

