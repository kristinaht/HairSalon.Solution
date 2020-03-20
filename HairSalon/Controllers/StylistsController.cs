using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq; //allows using ToList() method
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Controllers
{
  public class StylistsController: Controller
  {
    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList(); //ToList() used instead GetAll()
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {

      // int id needs to match the anonymous object created previously.
      //look at _db.Stylists -- this is stylists table in database
      //find stylists where Stylistid matches the id passed into this method.
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(thisStylist);

    }
  }
}