using Microsoft.AspNetCore.Mvc;
using SoojinProject1.Models;
using SoojinProject1.Data;


namespace SoojinProject1.Controllers
{
    public class ContactController : Controller
    {
        private readonly SoojinProject1Context _context;
        public IActionResult Index()
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

        }
    }