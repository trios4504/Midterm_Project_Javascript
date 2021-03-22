using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Module_1.Models;
using Module_5.Models;
using Midterm_Project.Models;

namespace Module_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Register(string User, string Password)
        {
            User user = new User();
            user.UserName = User;
            user.Password = Password;
            user.RegisterMessage = $"The user is {User} and the password is {Password}";

            return Json(user);
        }

        public IActionResult GetAllImages()
        {
            List<Images> imagesList = new List<Images>();

            Images newImage = new Images();
            newImage.Description = "Description 1";
            newImage.ImageAlt = "Image 1";
            newImage.ImagesId = 1;
            newImage.ImagePath = "some path";
            imagesList.Add(newImage);

            newImage = new Images();
            newImage.Description = "Description 2";
            newImage.ImageAlt = "Image 2";
            newImage.ImagesId = 2;
            newImage.ImagePath = "some path";
            imagesList.Add(newImage);

            newImage = new Images();
            newImage.Description = "Description 3";
            newImage.ImageAlt = "Image 3";
            newImage.ImagesId = 3;
            newImage.ImagePath = "some path";
            imagesList.Add(newImage);

            newImage = new Images();
            newImage.Description = "Description 4";
            newImage.ImageAlt = "Image 4";
            newImage.ImagesId = 4;
            newImage.ImagePath = "some path";
            imagesList.Add(newImage);

            newImage = new Images();
            newImage.Description = "Description 5";
            newImage.ImageAlt = "Image 5";
            newImage.ImagesId = 5;
            newImage.ImagePath = "some path";
            imagesList.Add(newImage);

            newImage = new Images();
            newImage.Description = "Description 6";
            newImage.ImageAlt = "Image 6";
            newImage.ImagesId = 6;
            newImage.ImagePath = "some path";
            imagesList.Add(newImage);

            newImage = new Images();
            newImage.Description = "Description 7";
            newImage.ImageAlt = "Image 7";
            newImage.ImagesId = 7;
            newImage.ImagePath = "some path";
            imagesList.Add(newImage);

            newImage = new Images();
            newImage.Description = "Description 8";
            newImage.ImageAlt = "Image 8";
            newImage.ImagesId = 8;
            newImage.ImagePath = "some path";
            imagesList.Add(newImage);

            newImage = new Images();
            newImage.Description = "Description 9";
            newImage.ImageAlt = "Image 9";
            newImage.ImagesId = 9;
            newImage.ImagePath = "some path";
            imagesList.Add(newImage);

            newImage = new Images();
            newImage.Description = "Description 10";
            newImage.ImageAlt = "Image 10";
            newImage.ImagesId = 10;
            newImage.ImagePath = "some path";
            imagesList.Add(newImage);

            newImage = new Images();
            newImage.Description = "Description 11";
            newImage.ImageAlt = "Image 11";
            newImage.ImagesId = 11;
            newImage.ImagePath = "some path";
            imagesList.Add(newImage);

            newImage = new Images();
            newImage.Description = "Description 12";
            newImage.ImageAlt = "Image 12";
            newImage.ImagesId = 12;
            newImage.ImagePath = "some path";
            imagesList.Add(newImage);

            newImage = new Images();
            newImage.Description = "Description 13";
            newImage.ImageAlt = "Image 13";
            newImage.ImagesId = 13;
            newImage.ImagePath = "some path";
            imagesList.Add(newImage);

            newImage = new Images();
            newImage.Description = "Description 14";
            newImage.ImageAlt = "Image 14";
            newImage.ImagesId = 14;
            newImage.ImagePath = "some path";
            imagesList.Add(newImage);

            newImage = new Images();
            newImage.Description = "Description 15";
            newImage.ImageAlt = "Image 15";
            newImage.ImagesId = 15;
            newImage.ImagePath = "some path";
            imagesList.Add(newImage);

            newImage = new Images();
            newImage.Description = "Description 16";
            newImage.ImageAlt = "Image 16";
            newImage.ImagesId = 16;
            newImage.ImagePath = "some path";
            imagesList.Add(newImage);

            newImage = new Images();
            newImage.Description = "Description 17";
            newImage.ImageAlt = "Image 17";
            newImage.ImagesId = 17;
            newImage.ImagePath = "some path";
            imagesList.Add(newImage);

            newImage = new Images();
            newImage.Description = "Description 18";
            newImage.ImageAlt = "Image 18";
            newImage.ImagesId = 18;
            newImage.ImagePath = "some path";
            imagesList.Add(newImage);

            newImage = new Images();
            newImage.Description = "Description 19";
            newImage.ImageAlt = "Image 19";
            newImage.ImagesId = 19;
            newImage.ImagePath = "some path";
            imagesList.Add(newImage);

            newImage = new Images();
            newImage.Description = "Description 20";
            newImage.ImageAlt = "Image 20";
            newImage.ImagesId = 20;
            newImage.ImagePath = "some path";
            imagesList.Add(newImage);




            return Json(imagesList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
