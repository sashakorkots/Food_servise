using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<DishsOfOrder> DishsOfOrder { get; set; }
        public int CustomerId { get; set; }
        public Customer CustomerOfDish { get; set; }
        public int CourierId { get; set; }
        public Courier Courier { get; set; }
    }
}