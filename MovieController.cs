using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVC_Crud_Ope.Models;

namespace MVC_Crud_Ope.Controllers
{
    public class MovieController : Controller
    {
        MoviedbEntities mdb = new MoviedbEntities();
        // GET: MovieTable
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetMoviesScaffolded()
        {
            List<Movietable> mv = mdb.Movietables.ToList();
            return View(mv);
        }
        //1. Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Movietable mt)
        {
            mdb.Movietables.Add(mt);
            mdb.SaveChanges();
            return RedirectToAction("GetMoviesScaffolded");
        }
        //2.Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Movietable ms = mdb.Movietables.Find(id);
            return View(ms);
        }
        [HttpPost]
        public ActionResult Edit(Movietable mt)
        {
            Movietable m = mdb.Movietables.Find(mt.Mid);
            m.Moviename = mt.Moviename;
            m.DateofRelease = mt.DateofRelease;
            mdb.SaveChanges();
            return RedirectToAction("GetMoviesScaffolded");
        }
        //3.Delete
        public ActionResult Delete(int id)
        {
            Movietable m = mdb.Movietables.Find(id);
            mdb.Movietables.Remove(m);
            mdb.SaveChanges();
            return RedirectToAction("GetMoviesScaffolded");
        }
        //4.Display the movie released in any given year

        public ActionResult GetMovieName(string val)
        {
            List<Movietable> mvt = (from r in mdb.Movietables
                                    where r.DateofRelease.ToString().Contains(val) || val == null
                                    select r).ToList();
            return View(mvt);
        }
        //5.Particular Details
        public ActionResult Details(int id)
        {
            Movietable mt = mdb.Movietables.Find(id);
            return View(mt);
        }

    }
}