using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Models
{
    public class T800 : BaseUnit
    {
        public T800() : base("T-800", 3)
        {
            BuildTime = 10;
        }
    }
}