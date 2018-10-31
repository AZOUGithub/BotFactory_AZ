using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Common.Tools
{
    public class Coordinates
    {
        public double X { get; set; }
        public double Y { get; set; }

        public override bool Equals(object obj)
        {
            Coordinates coordinates = (Coordinates)obj;

            return X == coordinates.X && Y == coordinates.Y;
        }
    }
}
