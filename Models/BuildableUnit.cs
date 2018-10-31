using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Models
{
    public abstract class BuildableUnit
    {
        private string Model { get; set; }
        public double BuildTime { get; set; }
        
        public BuildableUnit(double buildTime = 5)
        {
            BuildTime = buildTime;
        }
    }
}
