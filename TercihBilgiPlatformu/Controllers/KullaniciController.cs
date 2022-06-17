using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TercihBilgiPlatformu.Controllers
{
  public class KullaniciController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
