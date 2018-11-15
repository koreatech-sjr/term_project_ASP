using System;
using System.Collections.Generic;
using System.Linq;
using emptyProject.Model;
using Microsoft.AspNetCore.Mvc;

namespace emptyProject.Controller
{
    [Route("api/cities")]//position: up class + remove under slash
    public class PointOfInterestController: Microsoft.AspNetCore.Mvc.Controller
    {

        //
        [HttpGet("{id}/pointofinterest")]
        public IActionResult getPointsOfInterest(int id)
        {
            var cities = CitiesStore.Instance.cities;
            var city = cities.FirstOrDefault(c => c.id == id);
            return Ok(city.PointsOfInterest);

        }


        //
        [HttpGet("{id}/pointofinterest/{pointid}")]
        public IActionResult getPointsOfInterest(int id, int pointid)
        {
            var cities = CitiesStore.Instance.cities;
            var city = cities.FirstOrDefault(c => c.id == id);
            var point = city.PointsOfInterest.FirstOrDefault(p => p.id == pointid);
            return Ok(point);

        }

        // create point of interest
        [HttpPost("{cityid}/pointofinterest/")]
        public IActionResult createPointOfInterest(
            int cityid, 
            [FromBody]PointOfInterestForCreate pointofinterest
        ){
            //string result = $@"[name = { data.name }, description = { data.description } ]";

            //null exception
            if (pointofinterest == null) return BadRequest();

            List<CityDto> cities = CitiesStore.Instance.cities;
            CityDto city = null;
            foreach(var c in cities){
                if(c.id == cityid){
                    city = c;
                }
            }
            //no city exception
            if (city == null) return NotFound();

            //search maxid
            var points = city.PointsOfInterest;
            int maxid = 0;
            foreach (var p in points)
            {
                if (p.id > maxid) maxid = p.id;
            }
            //new point of interest
            var createdPointOfInterest = new PointOfInterestDto()
            {
                id = maxid + 1,
                name = pointofinterest.name,
                description = pointofinterest.description
            };
            //add point of interest
            points.Add(createdPointOfInterest);


            return Ok();
        }


        public PointOfInterestController()
        {
        }
    }
}
