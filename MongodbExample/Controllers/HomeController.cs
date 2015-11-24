using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB;
using MongoDB.Shared;
using MongoDB.Driver;
using MongodbExample.Models; 
using MongoDB.Driver.Core;
using System.Threading.Tasks;

namespace MongodbExample.Controllers
{

    public class HomeController : Controller
    {
        private MongoClient client = new MongoClient("mongodb://localhost:27017");

        public async Task<ActionResult> Index()
        {
            var database = client.GetDatabase("Employee");
            var collection = database.GetCollection<Employee>("employee");
            var data = await collection.Find<Employee>(x => true).ToListAsync();
            return View(data);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Employee employee)
        {
            if(ModelState.IsValid)
            {
                var database = client.GetDatabase("Employee");
                var collection = database.GetCollection<Employee>("employee");
                await collection.InsertOneAsync(employee);
            }
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}