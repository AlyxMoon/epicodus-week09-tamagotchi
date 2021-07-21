using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
  public class PetController : Controller
  {
    [HttpGet("pets")]
    public ActionResult Index()
    {
      PetManager.SetPet(1, "Bob");
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
  }
}