/***************************************************************************
    Author: Sahar Saeednooran
    File: FoodModels.cs 
    Purpose: Includes Classes related to bussiness logic for the aplication and
             helper methods for file IO handling
    Last Modified: Feb 18th, 2018
    **************************************************************************/
using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace CanFood.Models
{
    public class SuperFood
    {
        /// <summary>
        /// Gets and Sets MonthYear
        /// </summary>
        public string MonthYear { get; set; }
        /// <summary>
        /// Gets and Sets Region
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// Gets and Sets food Category
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// gets and sets cordinate vector, 
        /// this has not been used in this application, needs refactoring later
        /// </summary>
        public string vec1 { get; set; }
        /// <summary>
        /// gets and sets vector value, 
        /// this has not been used in this application, needs refactoring later
        /// </summary>
        public string vec2 { get; set; }
        /// <summary>
        /// gets and sets Value for the food record 
        /// </summary>
        public string ValueString { get; set; }
    }

    /// <summary>
    /// Implementation of Food object acording to csv columns 
    /// </summary>
    public class Food
    {
        /// <summary>
        /// ID for database
        /// </summary>
        public int ID { get; set;  }
        /// <summary>
        /// Gets and Sets MonthYear
        /// </summary>
        public string MonthYear { get; set; }
        /// <summary>
        /// Gets and Sets Region
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// Gets and Sets food Category
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// gets and sets cordinate vector, 
        /// this has not been used in this application, needs refactoring later
        /// </summary>
        public string vec1 { get; set; }
        /// <summary>
        /// gets and sets vector value, 
        /// this has not been used in this application, needs refactoring later
        /// </summary>
        public string vec2 { get; set; }
        public double Value { get; set; }
        public Food() { }
        public Food(SuperFood superFood)
        {
            MonthYear = superFood.MonthYear;
            vec1 = superFood.vec1;
            vec2 = superFood.vec2;
            Region = superFood.Region;
            Category = superFood.Category;
            try
            {
                Value = Convert.ToDouble(superFood.ValueString);
            }
            catch
            {
                Value = 0;
            }
        }
    }

    /// <summary>
    /// Handles CSV file using CsvHelper API
    /// </summary>
    public class CSVManager
    {
        /// <summary>
        /// Static Method to read a csv to a list of food objects 
        /// </summary>
        /// <param name="maxRecords">number of record to read from csv</param>
        /// <returns>list of food objects</returns>
        public static List<SuperFood> ReadInCSV()
        {
            List<SuperFood> results = new List<SuperFood>();
            // TODO: don use hard code path
            string path = HostingEnvironment.MapPath("~/App_Data/03290040-eng.csv");
            // TODO: exception handling 
            TextReader fileReader = File.OpenText(path);
            var csv = new CsvReader(fileReader);
            csv.Configuration.HasHeaderRecord = false;
            while (csv.Read())
            {
                SuperFood f = csv.GetRecord<SuperFood>();
                results.Add(f);
            }
            return results;
        }
    }
    /// <summary>
    /// Handles csv using system.IO
    /// this one is not needed in future, can be removed
    /// </summary>
    public class txtManager
    {
        /// <summary>
        /// static method to read a test file to Array of strings
        /// </summary>
        /// <returns>Array of strings, each element is one line in the file </returns>
        public static Array ReadInCSV()
        {
            string path = HostingEnvironment.MapPath("~/App_Data/03290040-eng.csv");

            Array results = null;
            try
            {
                if (File.Exists(path))
                {
                    results = File.ReadAllLines(path);
                }
            }
            catch
            {
            }
            return results;
        }
    }
}


