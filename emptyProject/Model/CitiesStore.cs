using System;
using System.Collections.Generic;

namespace emptyProject.Model
{
    public class CitiesStore
    {
        public static CitiesStore Instance { get; } = new CitiesStore();

        public List<CityDto> cities { get; set; }
        private CitiesStore()
        {
            cities = new List<CityDto>(){
                new CityDto(){
                    id = 2,
                    name = "seoul",
                    description = "dddddsss",
                    PointsOfInterest = new List<PointOfInterestDto> {
                        new PointOfInterestDto() {
                            id = 1,
                            name = "koreatech",
                            description = "hellll"
                        },
                        new PointOfInterestDto() {
                            id = 2,
                            name = "yaworiee",
                            description = "df"
                        }
                    }
                },
                new CityDto(){
                    id = 3,
                    name = "chunan",
                    description = "dddddsssssssss",
                    PointsOfInterest = new List<PointOfInterestDto> {
                        new PointOfInterestDto() {
                            id = 1,
                            name = "rerer",
                            description = "hsdsdsdllll"
                        },
                        new PointOfInterestDto() {
                            id = 2,
                            name = "sfsfsfsf",
                            description = "df"
                        }
                    }

                },
                new CityDto(){
                    id = 4,
                    name = "hell",
                    description = "dddddsssssssss!!!!!",
                    PointsOfInterest = new List<PointOfInterestDto> {
                        new PointOfInterestDto() {
                            id = 1,
                            name = "koreatech",
                            description = "hellll"
                        },
                        new PointOfInterestDto() {
                            id = 2,
                            name = "yaworiee",
                            description = "df"
                        }
                    }
                },
            };
        }
    }
}
