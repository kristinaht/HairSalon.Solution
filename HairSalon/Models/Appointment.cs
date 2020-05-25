using System;


namespace HairSalon.Models
{
  public class Appointment
  {
    public string Notes { get; set; }
    public DateTime Date { get; set; }

    public int ClientId { get; set; }
    public Client Client { get; set; }
  }
}