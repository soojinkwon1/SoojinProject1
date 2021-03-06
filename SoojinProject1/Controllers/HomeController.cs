using Microsoft.AspNetCore.Mvc;
using SoojinProject1.Data;
using SoojinProject1.Models;
using System.Diagnostics;

namespace SoojinProject1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SoojinProject1Context _context;

        public HomeController(ILogger<HomeController> logger, SoojinProject1Context context)
        {
            _logger = logger;
            _context = context;
        }

        
        public IActionResult Index()
        {
            return View();
        }


        [Route("/projects")]
        public IActionResult Projects()
        {
            return View();
        }


        [Route("/contact")]
        public IActionResult Contact()
        {
            return View();
        }


        [Route("/cv")]
        public IActionResult CV()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LeaveMessage(string Name, string email, string message)
        {
            Message message1 = new Message();
            message1.Name = Name;
            message1.Email = email;
            message1.MessageBody = message;
            message1.CreatedAt = DateTime.Now;
            _context.Messages.Add(message1);
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                return NotFound();
            }
            ViewData["msg"] = $"A message from {Name}, {email}, body: {message}. <br /> has been sent successfully.";

            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}