using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.OptionsModel;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Demo
{
    public class HomeController : Controller
    {
        public HomeController(IOptions<Config> config)
        {
            Config = config.Value;
        }

        Config Config { get; }

        public IActionResult Index()
        {
            return Content($"Name: {Config.Name}\nAge: {Config.Age}");
        }
    }
}
