namespace Tamagotchi.Models
{
  public class PetManager
  {
    public Pet Pets { get; set; }

    public int Id { get; set; }

    public void SetPet(int id, string name)
    {
      Pets = new(id, name);
    }
    public void PassTime()
    {
      Pets.Energy -= 10;
      Pets.Content -= 10;
      Pets.Sustenance -= 10;
      Pets.Quenched -= 10;
    }
  }
}