using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Item
  {
    public string Name { get; set; }
    public bool Purchased { get; set; }
    public double Weight { get; set; }
    public int Id { get; }
    public static List<Item> _instances = new List<Item> { };

    public Item(string name, bool purchased, double weight)
    {
      Name = name;
      Purchased = purchased;
      Weight = weight;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Item Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}