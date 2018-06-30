using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LungeloNeneTest.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
				[HttpGet]
				public ActionResult Login()
				{
						return View();
				}
				[HttpPost]
				public ActionResult Index(Models.login login)
				{
						if (ModelState.IsValid)
						{
								if (login.IsValid(login.username, login.password))
								{
										FormsAuthentication.SetAuthCookie(login.username, login.RememberMe);
										return RedirectToAction("Index", "Home");
								}
								else
								{
										ModelState.AddModelError("", "Login data is incorrect!");
								}
						}
						return View(login);
				}
				public ActionResult Logout()
				{
						FormsAuthentication.SignOut();
						return RedirectToAction("Index", "Home");
				}
		}
}