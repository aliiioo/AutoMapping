using AutoMapper;
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



        public HomeController(ILogger<HomeController> logger, IMapper mapper)
        {
            _mapper = mapper;
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



        // we want to work with List by AutoMapper
        public string ListofTeachersVmToTeachers()
        {
            // Cinvert the list of things to other things with AutoMapper
            //seed
            #region Seeds
            List<TeacherVeiwModel> teacherVeiwModels = new List<TeacherVeiwModel>()
            {
                new TeacherVeiwModel() {
                    name = "Ali",
                    Usrename= "AliRanjabran",
                    Adderss="...",
                    City="...",
                    Age=22,
                    Description="I'm ali Ranjabran .Net developer and fullstack",
                    Email="aliii4elemnt@gmail.com",
                    PhoneNumber="09190757149"
                },
            new TeacherVeiwModel()
            {
                    name = "Asal",
                    Usrename= "Asali",
                    Adderss="...",
                    City="...",
                    Age=22,
                    Description="fullstack",
                    Email="Asal@gmail.com",
                    PhoneNumber="000"
            }
            };
            #endregion
            var teacher = _mapper.Map<List<Teacher>>(teacherVeiwModels);
            return "ok";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}