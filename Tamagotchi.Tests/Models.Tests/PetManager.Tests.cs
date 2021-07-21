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
      Assert.IsNull(PetManager.Pets);
    }

    [TestMethod]
    public void SetPet_CorrectlySetsThePet_HasCorrectIdAndName ()
    {
      PetManager.SetPet(10, "Ron");

      Assert.IsInstanceOfType(PetManager.Pets, typeof(Pet));
      Assert.AreEqual(10, PetManager.Pets.Id);
      Assert.AreEqual("Ron", PetManager.Pets.Name);
    }

    [TestMethod]
    public void PassTime_UpdatesPetStats_ReducesEverythingBy10 ()
    {
      PetManager.SetPet(1, "Ron");

      Assert.AreEqual(100, PetManager.Pets.Energy);
      Assert.AreEqual(100, PetManager.Pets.Content);
      Assert.AreEqual(100, PetManager.Pets.Sustenance);
      Assert.AreEqual(100, PetManager.Pets.Quenched);

      PetManager.PassTime();
      Assert.AreEqual(90, PetManager.Pets.Energy);
      Assert.AreEqual(90, PetManager.Pets.Content);
      Assert.AreEqual(90, PetManager.Pets.Sustenance);
      Assert.AreEqual(90, PetManager.Pets.Quenched);

      PetManager.PassTime();
      Assert.AreEqual(80, PetManager.Pets.Energy);
      Assert.AreEqual(80, PetManager.Pets.Content);
      Assert.AreEqual(80, PetManager.Pets.Sustenance);
      Assert.AreEqual(80, PetManager.Pets.Quenched);
    }

    [TestMethod]
    public void IsDead_ReturnsCorrectBoolean_ReturnsFalseWhenAllValuesAbout0 ()
    {
      PetManager.SetPet(1, "Ron");

      Assert.IsFalse(PetManager.IsDead());
    }

    [TestMethod]
    public void IsDead_ReturnsCorrectBoolean_ReturnsTrueWhenEnergyIsAtOrBelow0 ()
    {
      PetManager.SetPet(1, "Ron");

      PetManager.Pets.Energy = 0;
      Assert.IsTrue(PetManager.IsDead());
      PetManager.Pets.Energy = -1;
      Assert.IsTrue(PetManager.IsDead());
    }

    [TestMethod]
    public void IsDead_ReturnsCorrectBoolean_ReturnsTrueWhenContentIsAtOrBelow0 ()
    {
      PetManager.SetPet(1, "Ron");

      PetManager.Pets.Content = 0;
      Assert.IsTrue(PetManager.IsDead());
      PetManager.Pets.Content = -1;
      Assert.IsTrue(PetManager.IsDead());
    }

    [TestMethod]
    public void IsDead_ReturnsCorrectBoolean_ReturnsTrueWhenSustenanceIsAtOrBelow0 ()
    {
      PetManager.SetPet(1, "Ron");

      PetManager.Pets.Sustenance = 0;
      Assert.IsTrue(PetManager.IsDead());
      PetManager.Pets.Sustenance = -1;
      Assert.IsTrue(PetManager.IsDead());
    }

    [TestMethod]
    public void IsDead_ReturnsCorrectBoolean_ReturnsTrueWhenQuenchedIsAtOrBelow0 ()
    {
      PetManager.SetPet(1, "Ron");

      PetManager.Pets.Quenched = 0;
      Assert.IsTrue(PetManager.IsDead());
      PetManager.Pets.Quenched = -1;
      Assert.IsTrue(PetManager.IsDead());
    }

    [TestMethod]
    public void Feed_UpdatesSustenance_IncreasesSustenanceBy10 ()
    {
      PetManager.SetPet(1, "Ron");
      PetManager.Pets.Sustenance = 90;
      PetManager.Feed();
      Assert.AreEqual(100, PetManager.Pets.Sustenance);
    }

    [TestMethod]
    public void Feed_UpdatesSustenance_CannotBeHigherThan200 ()
    {
      PetManager.SetPet(1, "Ron");
      PetManager.Pets.Sustenance = 195;
      PetManager.Feed();
      Assert.AreEqual(200, PetManager.Pets.Sustenance);
    }

    [TestMethod]
    public void Drink_UpdatesDrink_IncreasesDrinkBy10 ()
    {
      PetManager.SetPet(1, "Ron");
      PetManager.Pets.Quenched = 90;
      PetManager.Drink();
      Assert.AreEqual(100, PetManager.Pets.Quenched);
    }

    [TestMethod]
    public void Drink_UpdatesQuenched_CannotBeHigherThan200 ()
    {
      PetManager.SetPet(1, "Ron");
      PetManager.Pets.Quenched = 195;
      PetManager.Drink();
      Assert.AreEqual(200, PetManager.Pets.Quenched);
    }

    [TestMethod]
    public void Sleep_UpdatesEnergy_IncreasesEnergyBy10 ()
    {
      PetManager.SetPet(1, "Ron");
      PetManager.Pets.Energy = 90;
      PetManager.Sleep();
      Assert.AreEqual(100, PetManager.Pets.Energy);
    }

    [TestMethod]
    public void Sleep_UpdatesEnergy_CannotBeHigherThan200 ()
    {
      PetManager.SetPet(1, "Ron");
      PetManager.Pets.Energy = 195;
      PetManager.Sleep();
      Assert.AreEqual(200, PetManager.Pets.Energy);
    }

    [TestMethod]
    public void Attend_UpdatesContent_IncreasesContentBy10 ()
    {
      PetManager.SetPet(1, "Ron");
      PetManager.Pets.Content = 90;
      PetManager.Attend();
      Assert.AreEqual(100, PetManager.Pets.Content);
    }

    [TestMethod]
    public void Attend_UpdatesContent_CannotBeHigherThan200 ()
    {
      PetManager.SetPet(1, "Ron");
      PetManager.Pets.Content = 195;
      PetManager.Attend();
      Assert.AreEqual(200, PetManager.Pets.Content);
    }

  }
}