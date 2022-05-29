using Microsoft.AspNetCore.Mvc;
using modelBindingExampleMvc.Models.Context;
using modelBindingExampleMvc.Models.Entities;
using System.Linq;

namespace modelBindingExampleMvc.Controllers
{
    public class StudentController : Controller
    {
        StudentsContext db = new StudentsContext();
        public IActionResult Index()
        {
            var students = db.Students.ToList();
            return View(students);
        }



        public IActionResult StudentCreate()
        {
            var students = db.Students.OrderBy(x => x.id).ToList();
            return View(students);
        }
        [HttpPost]
        public IActionResult StudentCreate(Student student)
        {
            if (student!=null)
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
            
            return View(db.Students.OrderBy(x=>x.id).ToList());
        }

    }
}
