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
                    description = "dddddsss"
                },
                new CityDto(){
                    id = 3,
                    name = "chunan",
                    description = "dddddsssssssss"
                },
                new CityDto(){
                    id = 4,
                    name = "hell",
                    description = "dddddsssssssss!!!!!"
                },
            };
        }
    }
}
