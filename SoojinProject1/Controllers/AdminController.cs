using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoojinProject1.Data;

namespace SoojinProject1.Controllers
{
    public class AdminController : Controller
    {
        private readonly SoojinProject1Context _context;

        public AdminController(SoojinProject1Context context)
        {
            _context = context;
        }

        // GET: Admin/Messages
        public async Task<IActionResult> Messages()
        {
            return View(_context.Messages.OrderByDescending(x => x.Id).ToList());
        }

    }
}
