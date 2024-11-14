using Interview2.Data;
using Interview2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interview2.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Student model, string[] CourseName, string[] University, int[] Year, float[] Percentage)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(model);
                _context.SaveChanges();

                for (int i = 0; i < CourseName.Length; i++)
                {
                    var qualification = new Qualification
                    {
                        StudentID = model.StudentID,
                        CourseName = CourseName[i],
                        University = University[i],
                        Year = Year[i],
                        Percentage = (decimal)Percentage[i]
                    };
                    _context.Qualifications.Add(qualification);
                }

                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(model);
        }
    }
}
