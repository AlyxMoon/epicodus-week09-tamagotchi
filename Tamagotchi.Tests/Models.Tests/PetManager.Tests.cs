using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi.Models;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class PetManagerTests
  {
    [TestMethod]
    public void Constructor_InitializesWithCorrectValues ()
    {
      PetManager manager = new();

      Assert.IsNull(manager.Pets);
    }

    [TestMethod]
    public void SetPet_CorrectlySetsThePet_HasCorrectIdAndName ()
    {
      PetManager manager = new();
      manager.SetPet(10, "Ron");

      Assert.IsInstanceOfType(manager.Pets, typeof(Pet));
      Assert.AreEqual(10, manager.Pets.Id);
      Assert.AreEqual("Ron", manager.Pets.Name);
    }
  }
}