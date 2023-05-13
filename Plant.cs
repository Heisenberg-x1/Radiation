using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plant_Radiation_Project
{
    public abstract class Plant
    {
        protected string name;
        public int nutrientLevel;
        public bool isAlive;
        protected Plant(string name, int level)
        {
            this.name = name;
            this.nutrientLevel = level;
            isAlive = IsAlive();

        }
        public virtual bool IsAlive()
        {
            return true;
        }
        public abstract int Traverse(IRadiation radiation);
    }
    public class Wombleroot : Plant
    {
        public Wombleroot(string name, int level) : base(name, level) { }
        public override bool IsAlive()
        {
            return nutrientLevel > 0 && nutrientLevel < 10;
        }
        public int AlphaDemand()
        {
            if (nutrientLevel > 0)
            {
                return 10;
            }
            else
            {
                return 0;
            }
        }
        public override int Traverse(IRadiation R)
        {
            return R.EffectWombleroot(this);

        }

    }
    public class Wittentoot : Plant
    {
        public Wittentoot(string name, int level) : base(name, level) { }
        public override bool IsAlive()
        {
            return nutrientLevel > 0;
        }
        public int DeltaDemand()
        {
            if (nutrientLevel < 5)
            {
                return 4;
            }
            else if (nutrientLevel >= 5 && nutrientLevel <= 10)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public override int Traverse(IRadiation R)
        {
            return R.EffectWittentoot(this);
        }
    }
    public class Woreroot : Plant
    {
        public Woreroot(string name, int level) : base(name, level) { }
        public override bool IsAlive()
        {
            return nutrientLevel > 0;
        }
        public override int Traverse(IRadiation R)
        {
            return R.EffectWoreroot(this);
        }
    }
}
