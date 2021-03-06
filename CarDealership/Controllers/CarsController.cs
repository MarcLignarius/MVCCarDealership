using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealership.Models;
using System;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {

    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Cars> allCars = Cars.GetAll();
      return View(allCars);
    }

    [HttpPost("/cars")]
    public ActionResult Create(string makeModel, string color, int mileage, int price)
    {
      Cars myCar = new Cars(makeModel, color, mileage, price);
      return RedirectToAction("Index");
    }

    [Route("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

  }
}
