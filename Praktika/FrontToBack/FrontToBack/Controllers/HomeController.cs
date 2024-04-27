using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var datas = GetSliders();

            return View(datas);
        }

        private List<Slider> GetSliders()
        {
            return new List<Slider>
            {
                new Slider
                {
                    Id= 1,
                    Title = "Tofiq",
                    Descripton= "Heci"
                },

                new Slider
                {
                    Id= 2,
                    Title = "Rufet",
                    Descripton= "Nasosnu"
                },

                new Slider
                {
                    Id= 3,
                    Title = "Omer",
                    Descripton= "Xeyyam"
                }
            };
        }



    }
}