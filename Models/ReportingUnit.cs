using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Models
{
    public abstract class ReportingUnit
    {
        public delegate void ReportingUnitEventHandler(object sender, StatusChangedEventArgs args);
        public event ReportingUnitEventHandler UnitStatusChanged;

        public void OnStatusChanged(StatusChangedEventArgs args)
        {
            UnitStatusChanged(this, args);
        }
    }
}
