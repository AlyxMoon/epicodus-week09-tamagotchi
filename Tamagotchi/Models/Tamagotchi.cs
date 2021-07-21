
namespace Tamagotchi.Models
{
  public class Pet
  {
    public string Name { get; set; }
    public int Id { get; }
    public int Energy { get; set; }
    public int Content { get; set; }
    public int Sustenance { get; set; }
    public int Quenched { get; set; }
    public Pet(int id, string name)
    {
      Name = name;
      Id = id;
      Energy = 100;
      Content = 100;
      Sustenance = 100;
      Quenched = 100;
    }
  }
}