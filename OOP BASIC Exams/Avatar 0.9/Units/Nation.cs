using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Nation
    {
        private List<Bender> benders;
        private List<Monument> monuments;
        public string type;
        private double totalpower { get; set; }

        public Nation(string type)
        {
            this.benders = new List<Bender>();
            this.monuments = new List<Monument>();
            this.type = type;
        }
        public void ClearPower()
        {
            this.totalpower = 0;
            this.benders.Clear();
            this.monuments.Clear();
        }
        public void AddBender(Bender bender)
        {
            benders.Add(bender);
        }
        public void AddMonumnet(Monument monumnet)
        {
            this.monuments.Add(monumnet);
        }
        public double Calculate()
        {
            this.totalpower = benders.Sum(b => b.GetTotalPower());
            double monumnetpower = monuments.Sum(b => b.GetTotalPower());

            if (benders.Count != 0)
            {
                this.totalpower += (this.totalpower / 100) * monumnetpower;
            }
            return totalpower;
        }
        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendLine($"{this.type} Nation");
            if (this.benders.Count == 0)
            {
                str.AppendLine($"Benders: None");
            }
            else
            {
                str.AppendLine("Benders:");
                str.AppendLine(string.Join(Environment.NewLine, this.benders.Select(b => $"###{this.type} Bender: {b.ToString()}")));
            }

            if (monuments.Count == 0)
            {
                str.AppendLine("Monuments: None");
            }
            else
            {
                str.AppendLine("Monuments:");
                str.AppendLine(string.Join(Environment.NewLine,this.monuments.Select(m => $"###{this.type} Monument: {m.ToString()}")));
            }
            return str.ToString().Trim();
        }
    }

