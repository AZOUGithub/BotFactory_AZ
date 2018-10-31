using BotFactory.Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Models
{
    public interface IWorkingUnit
    {
        int BuildTime { get; set; }
        string Model { get; set; }
        string Name { get; set; }
        double Speed { get; set; }
        Coordinates CurrentPos { get; set; }
        Coordinates ParkingPos { get; set; }
        Coordinates WorkingPos { get; set; }
        bool isWorking { get; set; }
        void WorkBegins();
        void WorkEnds();
        void Move(Coordinates destination);
    }
}
