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
    public static string Feed()
    {
      bool wentOver = Pets.Sustenance + 10 > 200;
      if (wentOver)
      {
        Pets.Message = "I am fed, stop!";
      }

      Pets.Sustenance = Math.Min(Pets.Sustenance + 10, 200);

      return wentOver ? "I am fed, stop!" : "";
    }
    public static string Drink()
    {
      bool wentOver = Pets.Quenched + 10 > 200;
      if (wentOver)
      {
        Pets.Message = "AARRHGGH IM DROWNINGGG glugglug...";
      }

      Pets.Quenched = Math.Min(Pets.Quenched + 10, 200);      

      return Pets.Message;
    }
    public static string Sleep()
    {
      bool wentOver = Pets.Energy + 10 > 200;
      if (wentOver)
      {
        Pets.Message = "I don't want to go to bed, stop!";
      }

      Pets.Energy = Math.Min(Pets.Energy + 10, 200);

      return Pets.Message;
    }
    public static string Attend()
    {
      bool wentOver = Pets.Content + 10 > 200;
      if (wentOver)
      {
        Pets.Message = "I want alone time now, stop!";
      }

      Pets.Content = Math.Min(Pets.Content + 10, 200);

      return Pets.Message;
    }
  }
}