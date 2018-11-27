using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System;

namespace Parcels.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost("/parcels")]
        public ActionResult Parcels(int height, int width, int depth, int weight)
        {
            Parcel myParcel = new Parcel(height, width, depth, weight);
            return View(myParcel);
        }
    }
}