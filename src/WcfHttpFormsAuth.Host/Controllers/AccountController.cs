using System.Net;
using System.Web.Mvc;
using System.Web.Security;

namespace WcfHttpFormsAuth.Host.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
		[HttpGet]
        public ActionResult Logon() {
			Response.StatusCode = (int)HttpStatusCode.Unauthorized;
            return View();
        }



		[HttpPost]
		public ActionResult Logon(string username, string password) {
			if(Membership.ValidateUser(username, password)) {
				FormsAuthentication.SetAuthCookie(username,true);
			}
			return View();
		}

		public ActionResult LogOff() {
			FormsAuthentication.SignOut();
			return RedirectToAction("Logon", "Account");
		}
    }
}
