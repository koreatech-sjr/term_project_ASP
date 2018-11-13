using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using emptyProject.Model;
using System.Linq;

namespace emptyProject.Controller
{
    public class CitiesController : Microsoft.AspNetCore.Mvc.Controller
    {

        public CitiesController()
        {

        }
        [HttpGet("api/cities")]
        public IActionResult getCities() {
            return Ok(CitiesStore.Instance.cities);
        }

        [HttpGet("api/cities/{id}")]
        public IActionResult getSpecificCities(int id)
        {
            List<CityDto> list = CitiesStore.Instance.cities;
            CityDto result = list.FirstOrDefault(city => city.id == id);

            if( result == null ){
                return NotFound();
            }

            return Ok(result);
        }
    }
}
