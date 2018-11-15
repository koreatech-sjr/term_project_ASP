using System;
using System.Collections.Generic;

namespace emptyProject.Model
{
    public class CityDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int count
        {
            get
            {
                return PointsOfInterest.Count;
            }
        }
        public List<PointOfInterestDto> PointsOfInterest { get; set; }
    }
}

