using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistrationForm.Models;
using System.Data.Entity;
using System.Data.Entity.Utilities;

namespace RegistrationForm.Controllers
   
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult Enter()
        {
            Register obj = new Register();
            return View(obj);
        }
        [HttpPost]
        public ActionResult Enter(Register obj)
        {
            using (DbModels dobj = new DbModels())
            {
                if ((dobj.Registers.Any(x => x.Name == obj.Name)) && (dobj.Registers.Any(n => n.Nationality == obj.Nationality)) && (dobj.Registers.Any(c => c.Team == obj.Team)))
                {
                    ViewBag.DuplicateMessage = "Player already exist";
                    return View("Enter", obj);
                }
                else
                {
                    dobj.Registers.Add(obj);
                    dobj.SaveChanges();
                    return View("Record", dobj);
                }
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful";
            return View("Enter", new Register());

        }
        public ActionResult Record()
        {
            using (DbModels dobj = new DbModels())
            {
                return View(dobj.Registers.ToList());
            }

        }
        // GET: player/Edit/5
        public ActionResult Edit1(string id)
        {
            using (DbModels dobj = new DbModels())
            {
                return View(dobj.Registers.Where(x => x.Name ==  id).FirstOrDefault());
            }

        }

        // POST: player/Edit/5
        [HttpPost]
        public ActionResult Edit1(string id, Register register)
        {
            try
            {
                using (DbModels dobj = new DbModels())
                {
                    dobj.Entry(register).State = EntityState.Modified;
                    dobj.SaveChanges();
                }


                // TODO: Add update logic here

                return RedirectToAction("Enter");
            }
            catch
            {
                return View();
            }
        }





    }
}