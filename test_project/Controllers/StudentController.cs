using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_project.Context;

namespace test_project.Controllers
{
    public class StudentController : Controller
    {
        db_testEntities dbObj = new db_testEntities();

        //public StudentController(db_testEntities dbObj)
        //{
        //    this.dbObj = dbObj;
        //}

        // GET: Student
        [HttpGet]
        
        public ActionResult Student()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(tbl_Student model)
        {
            tbl_Student std_obj = new tbl_Student();
            
            std_obj.Name = model.Name;
            std_obj.Fname = model.Fname;
            std_obj.Email = model.Email;
            //std_obj.mobile = 
            std_obj.Description = model.Description;
            std_obj.Mobile = model.Mobile;

            dbObj.tbl_Student.Add(std_obj);
            dbObj.SaveChanges();
            return RedirectToAction("Student", "Student");
        }

        


    }
}