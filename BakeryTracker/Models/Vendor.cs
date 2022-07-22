using System.Collections.Generic;

namespace BakeryTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }

    public Vendor(string name, string description)
    {
      Description = description;
      Name = name;
    }
  }
}

