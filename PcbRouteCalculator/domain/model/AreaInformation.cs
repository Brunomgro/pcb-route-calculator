using System;
using CurrentInformation;

namespace AreaInformation

{
    class AreaInformations
    {
       public AreaInformations(Double _lengh, Double _current, Double _onca, Double _temperatureVariation, TrailType _trailType)
        {
            lengh = _lengh;
            current = _current;
            onca = _onca;
            temperatureVariation = _temperatureVariation;
            trailType = _trailType;
        }
        public Double lengh { get; set; }
        public Double current { get; set; }
        public Double onca { get; set; }
        public Double temperatureVariation { get; set; }
        public TrailType trailType { get; set; }

    }
}
