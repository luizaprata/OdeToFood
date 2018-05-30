﻿using OdeToFood.Entities;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.ViewModels.Home
{
    public class RestaurantEditModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }

        public CuisineType Cuisine { get; set; }
    }
}
