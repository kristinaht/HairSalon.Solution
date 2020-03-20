using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string Specialty { get; set; }
    public virtual ICollection<Stylist> Stylists { get; set; }

    public Stylist()
    {
      this.Stylists = new HashSet<Stylist>();
    }
  }
}