using System;
using CurrentInformation;
using AreaInformation;

namespace PcbCalculator
{
    class Calculator
    {
        public double currentThroughTrail1(AreaInformations areaInformations)
        {

            return areaInformations.current;
        }

        public double areaThroughCurrent(CurrentInformations currentInformations)
        {
            double constanteDaTrilha;
            if (currentInformations.trailType == TrailType.External)
            {
                constanteDaTrilha = 0.048;
            } else
            {
                constanteDaTrilha = 0.024;
            }

            double value = currentInformations.current / (constanteDaTrilha * Math.Pow(currentInformations.temperatureVariation, 0.44));

            double valueElevated = Math.Pow(value, 1.379);

            double valueCalculated = valueElevated / (1.378 * currentInformations.onca);

            return valueCalculated;
        }
    }
}
