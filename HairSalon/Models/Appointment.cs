using System;


namespace HairSalon.Models
{
  public class Appointment
  {
    public string Notes { get; set; }
    public DateTime Date { get; set; }

    public int StylistId { get; set; }
    public Stylist Stylist { get; set; }
  }
}