using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Common.Tools
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static Vector FromCoordinates(Coordinates begin, Coordinates end)
        {
            //  Calculer du vecteur à partir des points de départ et arrivée du vecteur
            Vector V = new Vector();
            V.X = end.X - begin.X;
            V.Y = end.Y - begin.Y;
            return V;
        }

        public double Length()
        {
            //  Longueur du vecteur
            return Math.Sqrt((X * X) + (Y * Y));
        }
    }
}
