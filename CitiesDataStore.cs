using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CoreApi.Models;

namespace CoreApi
{
    public class CitiesDataStore
    {
        //init dummy data
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            //dummy data
            Cities = new List<CityDto>()
            {

                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one that big park",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited urban park in the United States." 
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Midtown Manhattan." 
                        },
                    }
                },

                new CityDto()
                {
                    Id=2,
                    Name = "Antwrep",
                    Description = "The one that big park",PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Central Park",
                            Description = "The most visited urban park in the United States." 
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Midtown Manhattan." 
                        },
                    }
                },

                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one that big park",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Central Park",
                            Description = "The most visited urban park in the United States." 
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Midtown Manhattan." 
                        },
                    }
                }
            };
        }
    }
}