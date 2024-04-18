using Microsoft.AspNetCore.Mvc;
using WebAppProject.DBContext;

namespace WebAppProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserProfileManagerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserProfileManagerController(ApplicationDbContext context)

        {
            _context = context;
        }
        [Route("Admin/[controller]")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
