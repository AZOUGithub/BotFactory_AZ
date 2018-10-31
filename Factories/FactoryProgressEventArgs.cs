using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Factories
{
    public class FactoryProgressEventArgs : EventArgs
    {
        public FactoryQueueElement engram;
        public ITestingUnit unit;

    }
}
