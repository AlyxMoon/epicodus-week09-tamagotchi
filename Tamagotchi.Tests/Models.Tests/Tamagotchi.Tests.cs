using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi.Models;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class TamagotchiTests
  {
    [TestMethod]
    public void Constructor_InitializesWithCorrectValues ()
    {
      Pet pet = new(1, "Bob");

      Assert.AreEqual(1, pet.Id);
      Assert.AreEqual("Bob", pet.Name);
      Assert.AreEqual(100, pet.Energy);
      Assert.AreEqual(100, pet.Content);
      Assert.AreEqual(100, pet.Sustenance);
      Assert.AreEqual(100, pet.Quenched);
    }
  }
}