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

    [TestMethod]
    public void PassTime_UpdatesPetStats_ReducesEverythingBy10 ()
    {
      PetManager manager = new();
      manager.SetPet(1, "Ron");

      Assert.AreEqual(100, manager.Pets.Energy);
      Assert.AreEqual(100, manager.Pets.Content);
      Assert.AreEqual(100, manager.Pets.Sustenance);
      Assert.AreEqual(100, manager.Pets.Quenched);

      manager.PassTime();
      Assert.AreEqual(90, manager.Pets.Energy);
      Assert.AreEqual(90, manager.Pets.Content);
      Assert.AreEqual(90, manager.Pets.Sustenance);
      Assert.AreEqual(90, manager.Pets.Quenched);

      manager.PassTime();
      Assert.AreEqual(80, manager.Pets.Energy);
      Assert.AreEqual(80, manager.Pets.Content);
      Assert.AreEqual(80, manager.Pets.Sustenance);
      Assert.AreEqual(80, manager.Pets.Quenched);
    }

    [TestMethod]
    public void IsDead_ReturnsCorrectBoolean_ReturnsFalseWhenAllValuesAbout0 ()
    {
      PetManager manager = new();
      manager.SetPet(1, "Ron");

      Assert.IsFalse(manager.IsDead());
    }

    [TestMethod]
    public void IsDead_ReturnsCorrectBoolean_ReturnsTrueWhenEnergyIsAtOrBelow0 ()
    {
      PetManager manager = new();
      manager.SetPet(1, "Ron");

      manager.Pets.Energy = 0;
      Assert.IsTrue(manager.IsDead());
      manager.Pets.Energy = -1;
      Assert.IsTrue(manager.IsDead());
    }

    [TestMethod]
    public void IsDead_ReturnsCorrectBoolean_ReturnsTrueWhenContentIsAtOrBelow0 ()
    {
      PetManager manager = new();
      manager.SetPet(1, "Ron");

      manager.Pets.Content = 0;
      Assert.IsTrue(manager.IsDead());
      manager.Pets.Content = -1;
      Assert.IsTrue(manager.IsDead());
    }

    [TestMethod]
    public void IsDead_ReturnsCorrectBoolean_ReturnsTrueWhenSustenanceIsAtOrBelow0 ()
    {
      PetManager manager = new();
      manager.SetPet(1, "Ron");

      manager.Pets.Sustenance = 0;
      Assert.IsTrue(manager.IsDead());
      manager.Pets.Sustenance = -1;
      Assert.IsTrue(manager.IsDead());
    }

    [TestMethod]
    public void IsDead_ReturnsCorrectBoolean_ReturnsTrueWhenQuenchedIsAtOrBelow0 ()
    {
      PetManager manager = new();
      manager.SetPet(1, "Ron");

      manager.Pets.Quenched = 0;
      Assert.IsTrue(manager.IsDead());
      manager.Pets.Quenched = -1;
      Assert.IsTrue(manager.IsDead());
    }
  }
}