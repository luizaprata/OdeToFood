using OdeToFood.Entities;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Services
{

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant {Id = 1, Name="Scott Pizza" },
                new Restaurant {Id = 2, Name="Tersiguels" },
                new Restaurant {Id = 3, Name="Kings Salad" },
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }
    }
}
