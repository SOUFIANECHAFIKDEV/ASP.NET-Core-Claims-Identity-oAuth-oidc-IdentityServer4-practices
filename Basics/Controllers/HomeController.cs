using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Basics.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Secret()
        {
            return View();
        }

        public async Task<IActionResult> Authenticate()
        {
            /*
                Building up the user identity
             */

            var basicsClaims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, "Soufinae"),
                new Claim(ClaimTypes.Email, "Soufiane@mail.com"),
                new Claim("description", "I'm a DOTNET developer"),
            };

            var licenseClaims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, "Soufiane Chafik"),
                new Claim("DrivingLicenSe", "A+"),
            };

            var basicIdentity = new ClaimsIdentity(basicsClaims, "basics Identity");
            var licenseIdentity = new ClaimsIdentity(licenseClaims, "Gouvernment");

            var userProncipal = new ClaimsPrincipal(new[] { basicIdentity, licenseIdentity });

            //create the session
            await HttpContext.SignInAsync(userProncipal);

            return View("Index");
        }
    }
}
