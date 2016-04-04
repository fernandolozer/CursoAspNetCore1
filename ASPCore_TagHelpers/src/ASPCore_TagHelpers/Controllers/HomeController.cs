using ASPCore_TagHelpers.Models;
using Microsoft.AspNet.Mvc;
using System;

namespace ASPCore_TagHelpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(bool aprovado = true)
        {

            // retorna o websiteinfo preenchido e aplica a tag helper
            return View(new WebSiteInfo
            {
                Aprovado = aprovado,
                CopyrightAno = 2016,
                NumeroTags = 20,
                Version = new Version(1, 3, 4)
            });

            //return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
