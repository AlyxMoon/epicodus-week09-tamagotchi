using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
  public class PetController : Controller
  {
    [HttpGet("pets")]
    public ActionResult Index()
    {
      return View(PetManager.Pets);
    }

    [HttpPost("pets")]
    public ActionResult Create(string name)
    {
      PetManager.SetPet(1, name);
      return RedirectToAction("Index");
    }

    [HttpGet("pets/new")]
    public ActionResult New()
    {
      return View("Create");
    }

    [HttpGet("pets/stats/{prop}")]
    public ActionResult Patch(string prop) 
    {
      string message = prop switch
      {
        "Sustenance" => PetManager.Feed(),
        "Quenched" => PetManager.Drink(),
        "Content" => PetManager.Attend(),
        "Energy" => PetManager.Sleep(),
        _ => "",
      };

      return RedirectToAction("Index");
    }
  }
}