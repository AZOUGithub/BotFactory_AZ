using BotFactory.Common.Tools;
using BotFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Models
{
    public abstract class WorkingUnit : BaseUnit
    {
        public Coordinates ParkingPos { get; set; }
        public Coordinates WorkingPos { get; set; }
        public bool IsWorking { get; set; }

        public async void WorkBegins()
        {
            await Move(WorkingPos);
        }

        public async void WorkEnds()
        {
            await Move(ParkingPos);

        }

        public WorkingUnit(string name, double speed) : base(name, speed)
        {

        }
    }
}
