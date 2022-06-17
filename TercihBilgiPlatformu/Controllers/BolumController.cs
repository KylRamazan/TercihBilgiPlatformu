using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TercihBilgiPlatformu.Controllers
{
  public class BolumController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
