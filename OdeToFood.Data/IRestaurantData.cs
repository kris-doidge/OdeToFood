using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using OdeToFood.Domain;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
    }
    
    public class InMemoryRestaurantData : IRestaurantData
    {
        private IEnumerable<Restaurant> _restaurants;
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Location = "Tampa,FL", Name = "Chipotle", CuisineType = CuisineType.Indian},
                new Restaurant
                    {Id = 2, Location = "Tallahasse,FL", Name = "Guthries", CuisineType = CuisineType.Italian},
                new Restaurant {Id = 3, Location = "Fort Lee,NJ", Name = "Hirams", CuisineType = CuisineType.Italian}
            };
        }
        public IEnumerable<Restaurant> GetRestaurantsByName(string name)
        {
            return from r in _restaurants
                where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                orderby r.Name
                select r;
        }
    }
}