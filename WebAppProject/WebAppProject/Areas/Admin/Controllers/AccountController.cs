using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebAppProject.DBContext;
using WebAppProject.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAppProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)

        {
            _context = context;
        }
        [HttpGet]
        [Route("admin/[controller]/[action]")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("Admin/[controller]/[action]")]
        public IActionResult Login(string? url)
        {
            //ClaimsPrincipal claimUser = HttpContext.User;

            //if (claimUser.Identity.IsAuthenticated)
            //{
            //    return RedirectToAction("Index", url);
            //}
            return View();
        }

        [HttpPost]
        [Route("Admin/[controller]/[action]")]
        public async Task<IActionResult> Login(Login input)
        {
            var account = _context.Accounts.Include(account => account.Role).FirstOrDefault(x => x.EmailAddress == input.EmailAddress && x.Password == input.Password);
            if(account != null)
            {
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                 new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>() { new Claim(ClaimTypes.Name, ""), new Claim(ClaimTypes.Role, account.Role.RoleName) },
                CookieAuthenticationDefaults.AuthenticationScheme)), new AuthenticationProperties() { AllowRefresh = true, });

                if(account.Role.RoleName == "Admin")
                {
                    Response.Cookies.Append("AccountId", account.Id.ToString());
                    return RedirectToAction("Index", "UserProfileManager", new { area = "Admin" });
                }
            }
            ViewBag.Err = "Sai Tài Khoản Hoặc Mật Khẩu";
            return View();
        }
    }
}
