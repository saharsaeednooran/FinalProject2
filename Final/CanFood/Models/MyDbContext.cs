/***************************************************************************
    Author: Sahar Saeednooran
    Class: MyDbContext 
    Purpose: Implement database access 
             if it is the first time it will create a database
             using Entity Framework

    Last Modified: March 10th, 2018
    **************************************************************************/
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CanFood.Models
{
    /// <summary>
    /// MyDbContext instance can be used to query from a database
    /// or store data back into it
    /// </summary>
    public class MyDbContext : DbContext 
    {
        /// <summary>
        /// default constructor Connects to CanadaFoodStatistics.mdf database 
        /// if it is the first time it will generate a database
        /// </summary>
        public MyDbContext() : base("CanadianFoodStatistics")
        {
        }
        /// <summary>
        /// Collection of all entities of type Food in the database
        /// </summary>
        public DbSet<Food> Foods { get; set; }
    }



}