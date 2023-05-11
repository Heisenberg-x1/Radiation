using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plant_Radiation_Project
{
    public class NextDayRad
    {
        public int alphaDemand;
        public int deltaDemand;
        public NextDayRad(int alpha, int delta)
        {
            this.alphaDemand = alpha;
            this.deltaDemand = delta;
        }
        public string Radiation()
        {
            if ((alphaDemand - deltaDemand) >= 3)
            {
                return "alpha";
            }
            else if ((deltaDemand - alphaDemand) >= 3)
            {
                return "delta";
            }
            else
            {
                return "no radiation";
            }
        }
    }
}
