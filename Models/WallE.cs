﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Models
{
    public class WallE : BaseUnit
    {
        public WallE() : base("Wall-E", 2)
        {
            BuildTime = 4;
        }
    }
}
