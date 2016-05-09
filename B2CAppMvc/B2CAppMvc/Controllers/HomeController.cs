using B2CAppMvc.Properties;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace B2CAppMvc.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Action to show the claims from the Idp.
        /// </summary>
        /// <param name="token">Id token from B2C</param>
        /// <returns><View to iterate the claims in the token/returns>
        public ActionResult ShowToken(string token)
        {
            ViewBag.Title = Settings.Default.AppName;
            List<Claim> claims = null;
            if (!string.IsNullOrWhiteSpace(token))
            {
                claims = B2COpenidConnect.GetClaims(token);
            }

            return View(claims);
        }

        /// <summary>
        /// Default action
        /// </summary>
        /// <returns>Default view</returns>
        public ActionResult Index()
        {
            ViewBag.Title = Settings.Default.AppName;
            return View();
        }
    }
}