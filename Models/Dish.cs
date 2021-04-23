using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TypeOfDish { get; set; }
        public string SpeedOfCooking { get; set; }
        public decimal Price { get; set; }
        public List<Menu> MenuOfDish { get; set; }
        public List<DishsOfOrder> DishesOfOrder { get; set; }

    }
}