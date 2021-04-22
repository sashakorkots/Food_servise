using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
    public class DishsOfOrder
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order OrdersOfDish { get; set; }
        public int DishId { get; set; }        
        public Dish DishesOfOrder { get; set; }
    }
}


/* 
dotnet aspnet-codegenerator razorpage -m Courier -dc RazorPagesContext -udl -outDir Pages/Couriers --referenceScriptLibraries
dotnet aspnet-codegenerator razorpage -m Dish -dc RazorPagesContext -udl -outDir Pages/Dishs --referenceScriptLibraries 
dotnet aspnet-codegenerator razorpage -m DishOfOrder -dc RazorPagesContext -udl -outDir Pages/DishOfOrders --referenceScriptLibraries 
dotnet aspnet-codegenerator razorpage -m Menu -dc RazorPagesContext -udl -outDir Pages/Menus --referenceScriptLibraries 
dotnet aspnet-codegenerator razorpage -m Order -dc RazorPagesContext -udl -outDir Pages/Orders --referenceScriptLibraries 
dotnet aspnet-codegenerator razorpage -m Region -dc RazorPagesContext -udl -outDir Pages/Regions --referenceScriptLibraries 
dotnet aspnet-codegenerator razorpage -m Restrant -dc RazorPagesContext -udl -outDir Pages/Restrants --referenceScriptLibraries 
dotnet aspnet-codegenerator razorpage -m Customer -dc RazorPagesContext -udl -outDir Pages/Customers --referenceScriptLibraries 
 */