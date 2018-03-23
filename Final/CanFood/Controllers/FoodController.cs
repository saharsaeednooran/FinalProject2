/***************************************************************************
    Author: Sahar Saeednooran
    Class: FoodController 
    Purpose: Includes multiple ActionResult methods accosiated with each 
             View in /Food/ domain , passing Model to View when needed
    Last Modified: Feb 18th, 2018
    **************************************************************************/
using CanFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CanFood.Controllers
{
    /// <summary>
    /// FoodController inherits Controller, and handles Views (pages) in /Food/ domain
    /// </summary>
    public class FoodController : Controller
    {
        /// <summary>
        /// work in progress ... 
        /// instance of database to read from global database and pass information to View 
        /// </summary>
        private MyDbContext db = new MyDbContext();
        // GET: Food
        /// <summary>
        /// Reads data from CSV file and passes a linked list of Food objects to Reload View page
        /// </summary>
        /// <param name="id">Optional, number of records to read from CSV; defult value = 100</param>
        /// <returns>Releaod View page </returns>
       //// public ActionResult Reload(int? id)
       // {
            //// number of records to read from CSV and show on view page
            //int maxRecord = 100;
            //if (id.HasValue) maxRecord = (int)id;
            //// List of Food records 
            //List<SuperFood> results = CSVManager.ReadInCSV(maxRecord);
            //return View(results);
     //   }
        /// <summary>
        /// Reads data from CSV and passes an Array of strings to readText view page 
        /// </summary>
        /// <returns>readText view page</returns>
        public ActionResult readText()
        { 
            Array results = txtManager.ReadInCSV();
            return View("readText",results);
        }

        /// <summary>
        /// default controller to return index page in /Food/ domain
        /// </summary>
        /// <returns> ~/Food/Index view page</returns>
        public ActionResult Index()
        {
            return View("Index");
        }

        // GET: Food/Details/5
        /// <summary>
        /// work in progress ...
        /// to show details of one Food record in a seprate page
        /// </summary>
        /// <param name="id">record number to view details about</param>
        /// <returns>Detail view page</returns>
        public ActionResult Details(int id)
        {
            return View();
        }

        /// <summary>
        /// work in progress ...
        /// default create view page used if there is nothing to create 
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
  
                return View();
        }
        // POST: Food/Create
        /// <summary>
        /// work in progress ...
        /// reads a food record input from view page inserts it in database
        /// </summary>
        /// <param name="food">food object information read from view page</param>
        /// <returns>redirects to default index page if successful, otherwise stays in /~Food/Create page</returns>
        [HttpPost]
        public ActionResult Create(Food food)
        {
            try
            {
                db.Foods.Add(food);
                db.SaveChanges();

                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Food/Edit/5
        /// <summary>
        /// work in progresss ...
        /// default Edit page when there is nothing to edit 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(int id)
        {
            return View(id);
        }
        /// <summary>
        /// work in progress ...
        /// edit a Food record and save it back into database
        /// </summary>
        /// <param name="id">record id to be edited</param>
        /// <param name="collection">new information from view page to change</param>
        /// <returns>redirects to default index page if successful, otherwise stays in /~Food/edit page</returns>
        // POST: Food/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Food/Delete/5
        /// <summary>
        /// work in progress ...
        /// delete a food record from database
        /// </summary>
        /// <param name="id">record id to delete</param>
        /// <returns>redirects to default index page if successful, otherwise stays in /~Food/delete page</returns>
        public ActionResult Delete(int id)
        {
            return View();
        }

    }
}
