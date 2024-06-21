
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Teju.Models;

namespace Teju.Controllers
{
    public class SignupController : Controller
    {
        private readonly ILogger<SignupController> _logger;

        public SignupController(ILogger<SignupController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult LogToFile()
        {
         
           
            

            return View();
        }
    }
}
