using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SpaceDiscovery.Controllers
{
    public class SpaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult LogLastPosition(string message)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:51801/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/logdiscovery/" + message).Result;
            }   
            return Json(message);
        }
    }
}
