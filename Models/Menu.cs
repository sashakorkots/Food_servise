using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public int RestrantId { get; set; }
        public Restrant RestrantOfMenu { get; set; }
        public int DishId { get; set; }    
        public Dish DishOfMenu { get; set; }
    }
}