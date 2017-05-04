using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TheWorld.Models;
using TheWorld.Services;

namespace TheWorld.Controllers
{
    public class AppController : Controller
    {
        private IMailService _mailService;
        private IConfigurationRoot _config;
        private WorldContext _context;

        public AppController(IMailService mailService, IConfigurationRoot config, WorldContext context)
        {
            _mailService = mailService;
			_config = config;
            _context = context;
        }
        public IActionResult Index()
        {
            // get a list of trip objects
            var data = _context.Trips.ToList();
            
            return View(data);
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

			// add custom validation
			if (model.Email.Contains("aol.com"))
			{
				ModelState.AddModelError("Email", "AOL Addresses are for the birds");
			}

			// if all bits of the model look good
			if (ModelState.IsValid)
			{
				_mailService.SendMail(_config["MailSettings:ToAddress"], model.Email, "The World", model.Message);

                ModelState.Clear();
			}

            return View();
        }

        public IActionResult Form()
        {
            return View();
        }
    }
}
