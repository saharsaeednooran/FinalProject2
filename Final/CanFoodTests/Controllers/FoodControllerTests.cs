/***************************************************************************
    Author: Sahar Saeednooran
    Class: FoodControllerTests.cs
    Purpose: Unit Tests for FoodController Action Methods
    Last Modified: Feb 18th, 2018
    **************************************************************************/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using CanFood.Controllers;
using System.Web.Mvc;
/// <summary>
/// Unit tests for Controllers
/// </summary>
namespace CanFood.Controllers.Tests
{
    /// <summary>
    /// Testing FoodController Class
    /// </summary>
    [TestClass()]
    public class FoodControllerTests
    {
       
        /// <summary>
        ///  Unit testing readText Action Method form FoodController
        ///  a view request is mocked and test passes if the return action has the correct viewName = "readText"
        /// </summary>
        [TestMethod()]
        public void IndexTest()
        {
            FoodController foodController = new FoodController();
            var IndexActionResult = foodController.Index() as ViewResult;
            Assert.AreSame(foodController.ViewData, IndexActionResult.ViewData);
        }
    }
}