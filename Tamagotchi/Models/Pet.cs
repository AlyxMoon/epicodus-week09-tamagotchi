
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

    public int[] Stats {
      get {
        return new int[] { Energy, Content, Sustenance, Quenched };
      }
    }

    public Pet(int id, string name)
    {
      Name = name;
      Id = id;
      Energy = 100;
      Content = 100;
      Sustenance = 100;
      Quenched = 100;
    }

    /*
    What this does is allow use to use [] on an object instance of Pet, so like
    Pet myPet = new Pet(1, "Bob");
    myPet["Energy"];
    */

    // [System.Runtime.CompilerServices.IndexerName("item")]
    // public int this[string index]
    // {
    //   get {
    //     if (index == "Energy") return Energy;
    //     if (index == "Content") return Content;
    //     if (index == "Sustenance") return Sustenance;
    //     if (index == "Quenched") return Quenched;
    //     return 0;
    //   }
    // }
  }
}