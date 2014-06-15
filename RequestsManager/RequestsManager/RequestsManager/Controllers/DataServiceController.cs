using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using RequestsManager.Model;
using RequestsManager.Repository;

namespace RequestsManager.Controllers
{
    public class DataServiceController : Controller
    {
        public ActionResult SaveRequest(string comment, string countPeople, string orderDate, string customer)
        {
            using (var db = new DBContext())
            {
                Request newTask = new Request()
                {
                    OrderDate = DateTime.Parse(orderDate),
                    Comment = comment,
                    CountPeople = int.Parse(countPeople),
                    Customer = customer
                };

                db.Requests.Add(newTask);
                db.SaveChanges();
            }

            return null;
        }

        public JsonResult GetRequests()
        {
            using (var db = new DBContext())
            {
                var requests = db.Requests
                    .OrderByDescending(r => r.OrderDate)
                    .ToList();
                string jsonString = JsonConvert.SerializeObject(requests);
                return Json(jsonString);
            }
        }

    }
}
