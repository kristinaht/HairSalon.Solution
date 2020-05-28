using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  { 
    public Stylist()
    {
      this.Clients = new HashSet<StylistClient>(); //HashSet in constructor helps avoid exceptions hwen no records exist in the "many" side of the relationship.
    }
    public int StylistId { get; set; }

    public string Name { get; set; }
    public string Specialty { get; set; }
    public virtual ICollection<StylistClient> Clients { get; set; }
  }
}