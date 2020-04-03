using Microsoft.AspNetCore.Mvc;
using NationalParksClient.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace NationalParksClient.Controllers
{
  public class ParksController : Controller 
  {
    public IActionResult Index()
    {
      var allParks = Park.GetAll();
      return View(allParks);
    }
  }
}