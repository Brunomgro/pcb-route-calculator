using System;

namespace AreaInformation

{
    class AreaInformations
    {
       public AreaInformations(Double _lengh, Double _current, Double _onca, Double _temperatureVariation, TrailType _trailType)
        {
            trailType = _trailType;
            lengh = _lengh;
            current = _current;
            onca = _onca;
            temperatureVariation = _temperatureVariation;
        }
        public Double lengh { get; set; }
        public Double current { get; set; }
        public Double onca { get; set; }
        public Double temperatureVariation { get; set; }
        public TrailType trailType { get; set; }

    }
    enum TrailType
    {
        External,
        Internal
    }

}
