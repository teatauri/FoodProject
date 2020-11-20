using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FoodProject.Core;

namespace FoodProject.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Lee's Place", Location = "Southampton", Cuisine=CuisineType.Irish},
                new Restaurant { Id = 2, Name = "Pup's Place", Location = "Bangkok", Cuisine=CuisineType.Thai},
                new Restaurant { Id = 3, Name = "Archie's Place", Location = "Tokyo", Cuisine=CuisineType.Vietnamese},
                new Restaurant { Id = 4, Name = "Mum's Place", Location = "Newcastle", Cuisine=CuisineType.Indian}

            };

        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
