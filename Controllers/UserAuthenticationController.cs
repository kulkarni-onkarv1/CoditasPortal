using CoditasPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CoditasPortal.Controllers
{
    public class UserAuthenticationController : Controller
    {
        public IActionResult UserLogin()
        {
            return View();
        }

        public IActionResult UserRegistration()
        {
            var gender = new List<string>() { "Male", "Female" ,"Prefer not to say"};
            ViewBag.Gender = new SelectList(gender);
            return View(new RegisterUser() { });
        }
        [HttpPost]
        public IActionResult UserRegistration(RegisterUser registerUser)
        {
            return View("UserLogin");
        }

        [HttpPost]
        public JsonResult IsUserNameAvailable(string Email)
        {
            /*var getUser = userAccess.GetByEmailAsync(MailID).Result;
            if (getUser != null)
            {

                return Json(data: false);
            }*/
            /*var getStudent = instituteStudentsDataAccess.GetByEmail(MailID);
            if (getStudent == null)
            {
                return Json(data: "Enter Your Institute Mail ID Only");
            }*/
            return Json(data: true);
            /*IRouteHandler */
        }
    }
}
