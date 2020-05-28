using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
   public Client() 
   {
     this.Stylists = new HashSet<StylistClient>();
   }
    public int ClientId { get; set; }
    public string Name { get; set; }

    public ICollection<StylistClient> Stylists { get; }

    // public int StylistId { get; set; }
    // public virtual Stylist Stylist { get; set;}
  }
}