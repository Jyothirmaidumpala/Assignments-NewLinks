using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CodeFirstEx.Models;

namespace MVC_CodeFirstEx.Controllers
{
    public class StudentController : Controller
    {
        StudentContext sc = new StudentContext();
        // GET: Student
        public ActionResult Index()
        {
            List<Student> stud = sc.stud.ToList();
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            sc.stud.Add(s);
            sc.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Student sd = sc.stud.Find(id);
            return View(sd);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Student sd = sc.stud.Find(id);
            return View(sd);
        }
        [HttpPost]
        public ActionResult Edit(Student sd)
        {
            Student stud = sc.stud.Find(sd.id);
            stud.Name = sd.Name;
            stud.City = sd.City;
            stud.Branch = sd.Branch;
            stud.Percentage = sd.Percentage;
            sc.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id)
        {
            Student st = sc.stud.Find(id);
            sc.stud.Remove(st);
            sc.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Search_View_By_StudentDetails(string option,string str) 
        {
            if(option=="city")
            {
                return View(sc.stud.Where(y => y.City == str).ToList());
            }
            else if(option=="Branch")
            {
                return View(sc.stud.Where(y => y.Branch == str).ToList());
            }
            else if(option=="Percentage")
            {
                return View(sc.stud.Where(y => y.Percentage.ToString() == str).ToList());
            }
            else
            {
                return View(sc.stud.Where(y => y.id.ToString() == str).ToList());
            }
        }
    }
}