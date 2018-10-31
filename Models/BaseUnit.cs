using BotFactory.Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BotFactory.Models
{
    public class BaseUnit : BuildableUnit
    {
        public string Name { get; set; }
        public double Speed { get; set; }
        public Coordinates CurrentPos { get; set; }

        public BaseUnit(string name, double speed = 1)
        {
            Name = name;
            Speed = speed;

            CurrentPos = new Coordinates { X = 0, Y = 0 };
        }

        public async Task Move(Coordinates destination)
        {
            //  Temps de parcours t=D/V
            double travelTime = Vector.FromCoordinates(CurrentPos, destination).Length() / Speed;

            //  Ajout du délai d'exécution
            await Task.Run(async () =>
            {
                await Task.Delay(TimeSpan.FromHours(Math.Round(travelTime * 1000)));
                CurrentPos = destination;
            });
        }

    }
}
