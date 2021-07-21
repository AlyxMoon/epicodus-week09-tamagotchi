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
  }
}