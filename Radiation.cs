using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plant_Radiation_Project
{
    public interface IRadiation
    {
        public int EffectWombleroot(Wombleroot w);
        public int EffectWittentoot(Wittentoot w);
        public int EffectWoreroot(Woreroot w);
    }
    class Alpha : IRadiation
    {
        public int EffectWombleroot(Wombleroot wom)
        {
            int newNutrientlevel = wom.nutrientLevel += 2;
            return newNutrientlevel;
        }
        public int EffectWittentoot(Wittentoot wit)
        {
            int newNutrientLevel = wit.nutrientLevel -= 3;
            return newNutrientLevel;
        }
        public int EffectWoreroot(Woreroot wor)
        {
            int newNutrientLevel = wor.nutrientLevel += 1;
            return newNutrientLevel;

        }
    }
    class Delta : IRadiation
    {
        public int EffectWombleroot(Wombleroot wom)
        {
            int newNutrientLevel = wom.nutrientLevel -= 2;
            return newNutrientLevel;
        }
        public int EffectWittentoot(Wittentoot wit)
        {
            int newNutrientLevel = wit.nutrientLevel += 4;
            return newNutrientLevel;
        }
        public int EffectWoreroot(Woreroot wor)
        {
            int newNutrientLevel = wor.nutrientLevel += 1;
            return newNutrientLevel;

        }
    }
    class NoRadiation : IRadiation
    {
        public int EffectWombleroot(Wombleroot wom)
        {
            int newNutrientLevel = wom.nutrientLevel -= 1;
            return newNutrientLevel;
        }
        public int EffectWittentoot(Wittentoot wit)
        {
            int newNutrientLevel = wit.nutrientLevel -= 1;
            return newNutrientLevel;
        }
        public int EffectWoreroot(Woreroot wor)
        {
            int newNutrientLevel = wor.nutrientLevel -= 1;
            return newNutrientLevel;

        }
    }

}
