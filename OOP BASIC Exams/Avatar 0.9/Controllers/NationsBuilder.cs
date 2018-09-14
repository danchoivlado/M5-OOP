
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class NationsBuilder
    {
        private Nation airnation;
        private Nation waternation;
        private Nation firenation;
        private Nation earthnation;
        private StringBuilder warEnd;
        private int privateCounter;

        public NationsBuilder()
        {
            this.airnation = new Nation("Air");
            this.waternation = new Nation("Water");
            this.firenation = new Nation("Fire");
            this.earthnation = new Nation("Earth");
            this.privateCounter=1;
            warEnd = new StringBuilder();

        }

        public void AssignBender(List<string> benderArgs)
        {
            string type = benderArgs[0];
            string name = benderArgs[1];
            int power = int.Parse(benderArgs[2]);
            double sec = double.Parse(benderArgs[3]);
            switch (type)
            {
                case "Air":
                    airnation.AddBender(new AirBender(name, power, sec));
                    break;
                case "Water":
                    waternation.AddBender(new WaterBender(name, power, sec));
                    break;
                case "Fire":
                    firenation.AddBender(new FireBender(name, power, sec));
                    break;
                case "Earth":
                    earthnation.AddBender(new EarthBender(name, power, sec));
                    break;
                default:
                    throw new ArgumentException("no Bender Added");
            }
        }

        public void AssignMonument(List<string> monumentArgs)
        {
            string type = monumentArgs[0];
            string name = monumentArgs[1];
            int afinity = int.Parse(monumentArgs[2]);
            switch (type)
            {
                case "Air":
                    airnation.AddMonumnet(new AirMonument(name, afinity));
                    break;
                case "Water":
                    waternation.AddMonumnet(new WaterMonument(name, afinity));
                    break;
                case "Fire":
                    firenation.AddMonumnet(new FireMonument(name, afinity));
                    break;
                case "Earth":
                    earthnation.AddMonumnet(new EarthMonument(name, afinity));
                    break;

                default:
                    throw new ArgumentException("no Monument Added");

            }
        }

        public string GetStatus(string nationsType)
        {
            string type = nationsType;
            switch (type)
            {
                case "Air":
                    return airnation.ToString();

                case "Water":
                    return waternation.ToString();

                case "Fire":
                    return firenation.ToString();

                case "Earth":
                    return earthnation.ToString();
                default:
                    throw new ArgumentException("No To String");
            }
        }
        public void IssueWar(string nationsType)
        {
            warEnd.AppendLine($"War {privateCounter} issued by {nationsType}");
            privateCounter++;
            Dictionary<Nation, double> dic = new Dictionary<Nation, double>();
            dic.Add(airnation, airnation.Calculate());
            dic.Add(waternation, waternation.Calculate());
            dic.Add(firenation, firenation.Calculate());
            dic.Add(earthnation, earthnation.Calculate());
            dic = dic.OrderByDescending(a => a.Value).ToDictionary(a => a.Key, b => b.Value);
            foreach (var nat in dic.Skip(1))
            {
                switch (nat.Key.type)
                {
                    case "Air":
                        airnation.ClearPower();
                        break;
                    case "Water":
                        waternation.ClearPower();
                        break;
                    case "Fire":
                        firenation.ClearPower();
                        break;
                    case "Earth":
                        earthnation.ClearPower();
                        break;
                    default:
                        break;
                }
            }

        }
        public string GetWarsRecord()
        {
            //Console.WriteLine(string.Join("",warEnd.ToString().Trim()));
            return warEnd.ToString().Trim();
        }

    }

