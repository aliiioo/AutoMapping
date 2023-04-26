﻿using AutoMapper;
using AutoMappering.DTOs;
using AutoMappering.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AutoMappering.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;



        public HomeController(ILogger<HomeController> logger,IMapper mapper)
        {
            _mapper=mapper;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registering(UserVewModel userVewModeluser)
        {
            var users = _mapper.Map<User>(userVewModeluser);

            return RedirectToAction(nameof(Index));
        }     

       


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}