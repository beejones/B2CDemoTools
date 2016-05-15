using System.Security.Claims;
using System.Web.Mvc;

namespace B2CAppMvc.Controllers
{
    public class ClaimsController : Controller
    {
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View(((ClaimsIdentity)User.Identity).Claims);
            }

            return View((object)null);
        }
    }
}
