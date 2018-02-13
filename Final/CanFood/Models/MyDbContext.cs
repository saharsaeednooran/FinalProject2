using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CanFood.Models
{
    public class MyDbContext : DbContext 
    {
        public MyDbContext() : base("CanadaFoodStatistics")
        {

        }
        public DbSet<FoodModel> Foods { get; set; }
    }
}