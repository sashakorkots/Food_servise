using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
    public class Region
    {
        public int Id { get; set; }
        public int RestrantId { get; set; }
        public Restrant RestrantOfRegion { get; set; }
        public int CourierId { get; set; }
        public Courier CourierOfRegion { get; set; }
    }
}