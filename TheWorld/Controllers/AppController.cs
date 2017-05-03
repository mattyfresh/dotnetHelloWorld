using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheWorld.Services;

namespace TheWorld.Controllers
{
    public class AppController : Controller
    {
        private IMailService _mailService;

        public AppController(IMailService mailService)
        {
            _mailService = mailService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(TheWorld.ViewModels.ContactViewModel model)
        {
			_mailService.SendMail("cool@cool.com", model.Email, "The World", model.Message);
			
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }
    }
}
