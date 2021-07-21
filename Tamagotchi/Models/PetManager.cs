using System;

namespace Tamagotchi.Models
{
  public class PetManager
  {
    public static Pet Pets { get; set; }

    public static int Id { get; set; }

    public static void SetPet(int id, string name)
    {
      Pets = new(id, name);
    }
    public static void PassTime()
    {
      Pets.Energy -= 10;
      Pets.Content -= 10;
      Pets.Sustenance -= 10;
      Pets.Quenched -= 10;
    }

    public static bool IsDead()
    {
      foreach (int stat in Pets.Stats) {
        if (stat <= 0) return true;
      }

      return false;
    } 
    public static void Feed()
    {
      Pets.Sustenance = Math.Min(Pets.Sustenance + 10, 200);
    }
    public static void Drink()
    {
      Pets.Quenched = Math.Min(Pets.Quenched + 10, 200);
    }
    public static void Sleep()
    {
      Pets.Energy = Math.Min(Pets.Energy + 10, 200);
    }
    public static void Attend()
    {
      Pets.Content = Math.Min(Pets.Content + 10, 200);
    }
  }
}