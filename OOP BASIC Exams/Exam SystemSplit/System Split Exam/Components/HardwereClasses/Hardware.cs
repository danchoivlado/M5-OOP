using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public abstract class Hardware
    {
        public string Name { get;private set; }
        public abstract string Type { get; }
        public int MaxCapacity { get;private set; }
        public int MaxMemory { get;private set; }
        public int CurCapacity { get;private set; }
        public int CurMem { get;private set; }
        private List<Software> SoftwareComponents;

        public int SeeSoftwareType(string softwaretype)
        {
            return this.SoftwareComponents.Where(se => se.SoftwereType() == softwaretype).Count();
        }

        public int AllSoftwereSum()
        {
            return this.SoftwareComponents.Count;
        }

        public string Join()
        {
            if (this.SoftwareComponents.Count != 0)
            {
                return string.Join(", ", SoftwareComponents.Select(se => se.Name));
            }
            return "None";
        }
        public int CountOfExpressSoftwareComponents()
        {
            return this.SoftwareComponents.Where(se => se.Type == "ExpressSoftware").Count();
        }
        public int CountOfLightSoftwareComponents()
        {
            return this.SoftwareComponents.Where(se => se.Type == "LightSoftware").Count();
        }
        protected Hardware(string Name,int MaxMemory,int MaxCapacity)
        {
            this.SoftwareComponents = new List<Software>();
            this.Name = Name;
            this.MaxCapacity = MaxCapacity;
            this.MaxMemory = MaxMemory;
            this.CurMem = 0;
            this.CurCapacity = 0;
        }   
        public bool AddSoftwere(Software software)
        {
            bool Validate = software.CapConsuption + this.CurCapacity > this.MaxCapacity 
                || software.MemConsuption + this.CurMem > this.MaxMemory;
            if (!Validate)
            {
                this.SoftwareComponents.Add(software);
                this.CurCapacity += software.CapConsuption;
                this.CurMem += software.MemConsuption;
                return true;
            }
            return false;
        }
        public Software FindSoftware(string name)
        {
            return this.SoftwareComponents.FirstOrDefault(se => se.Name == name);
        }
        public void DeleteSoftware(Software software)
        {
            this.SoftwareComponents.Remove(software);
            this.CurCapacity -= software.CapConsuption;
            this.CurMem -= software.MemConsuption;
        }
    }

