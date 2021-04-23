using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
    public class DishsOfOrder
    {
        public int Id { get; set; }
        public int OrdersOfDishId { get; set; }
        public Order OrdersOfDish { get; set; }
        public int DishesOfOrderId { get; set; }        
        public Dish DishesOfOrder { get; set; }
    }
}


