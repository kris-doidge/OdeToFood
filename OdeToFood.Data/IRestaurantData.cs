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
       Restaurant GetRestaurantById(int id);
       Restaurant Update(Restaurant updatedRestaurant);
       Restaurant Add(Restaurant newRestaurant);
       int Commit();
    }
    
    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> _restaurants;
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

        public Restaurant GetRestaurantById(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var restaurant = _restaurants.SingleOrDefault(r => r.Id == updatedRestaurant.Id);
            if (restaurant != null)
            {
                restaurant.Name = updatedRestaurant.Name;
                restaurant.Location = updatedRestaurant.Location;
                restaurant.CuisineType = updatedRestaurant.CuisineType;
            }

            return restaurant;
        }

        public Restaurant Add(Restaurant newRestaurant)
        {
            _restaurants.Add(newRestaurant);
            newRestaurant.Id = _restaurants.Max(r => r.Id) + 1;
            return newRestaurant;
        }

        public int Commit()
        {
            return 0;
        }
    }
}