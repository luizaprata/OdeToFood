using OdeToFood.Entities;
using System.Collections.Generic;

namespace OdeToFood.ViewModels.Home
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentMessageOfTheDay { get; set; }
    }
}
