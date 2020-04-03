using Microsoft.AspNetCore.Mvc;
using NationalParksClient.Models;
using Microsoft.AspNetCore.Authorization;

namespace NationalParksClient.Controllers
{
  public class ParksController : Controller 
  {
  public IActionResult Index()
    {
      var allAnimals = Park.GetParks();
      return View(allAnimals);
    }

  public IActionResult Create()
    {
      return View();
    }

  [HttpPost]
  public IActionResult Create(Park park)
    {
      Park.Post(park);
      return RedirectToAction("Index");
    }
  public IActionResult Details(int id)
    {
      var park = Park.GetDetails(id);
      return View(park);
    }
  public IActionResult Edit(int id)
    {
      var park = Park.GetDetails(id);
      return View(park);
    }
        [HttpPost]
  public IActionResult Details(int id, Park park)
    {
      park.ParkId = id;
      Park.Put(park);
      return RedirectToAction("Details", id);
    }
  }
}