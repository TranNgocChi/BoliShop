﻿using BusinessObject.HomeViewModel;
using BusinessObject.Models;
using DataAccess.Repository.IObjectRepository;
using DataAccess.Repository.ObjectRepository;
using GauShop.ExternalServices.MailService;
using GauShop.Helpers;
using GauShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Caching.Distributed;
using System.Diagnostics;
using System.Security.Cryptography.Xml;
using System.Text;

namespace GauShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SessionHelper _sessionHelper;
        private readonly IDistributedCache _sessionCache;

        private readonly IUserRepository _userRepository = new UserRepository();
        private readonly ICartRepository _cartRepository = new CartRepository();
        private readonly IProductRepository _productRepository = new ProductRepository();
        public HomeController(ILogger<HomeController> logger, SessionHelper sessionHelper, IDistributedCache sessionCache)
        {
            _sessionHelper = sessionHelper;
            _logger = logger;
            _sessionCache = sessionCache;
        }

        [Route("/")]
        public async Task<IActionResult> Index()
        {
            var model = await _sessionHelper.GetHomeModel();
            model.products = _productRepository.ShowAll();
            return View(model);
        } 

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult TestSession()
        {
            int? count;
            count = HttpContext.Session.GetInt32("count");
            if (count == null)
            {
                count = 0;
            }
            count += 1;
            HttpContext.Session.SetInt32("count", count.Value);

            return Content("So lan truy cap: " + count);
        }

        [HttpPost]
        public async Task<IActionResult> Check(IFormFile file){
            if(file != null && file.Length > 0)
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", file.FileName);
                using(var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                ViewBag.Message = "Upload successfully";
            }
            else
            {
				ViewBag.Message = "Upload failed";
			}
            return View();
        }

        public IActionResult Check() => View();
        
    }
}


