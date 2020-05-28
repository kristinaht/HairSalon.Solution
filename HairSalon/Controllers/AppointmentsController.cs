// using Microsoft.AspNetCore.Mvc;
// using HairSalon.Models;
// using System.Collections.Generic;
// using System.Linq;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Mvc.Rendering;

// namespace HairSalon.Controllers
// {
//   public class AppointmentsController : Controller
//   {
//     private readonly HairSalonContext _db;

//     public AppointmentsController(HairSalonContext db)
//     {
//       _db = db;
//     }

//     public ActionResult Create()
//     { 
//       ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name", "Specialty");
//       return View();
//     }

//     [HttpPost]
//     public ActionResult Create(Appointment appointment)
//     {
//       _db.Appointments.Add(appointment);
//       _db.SaveChanges();
//       // return RedirectToAction("Index");
//       return RedirectToAction("Details", "Stylists", new {id = appointment.StylistId});
//     }

//   }
// }