using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MicroservicesClient.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace MicroservicesClient.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private HttpClient httpClient;

        public HomeController(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        

        public async Task<ActionResult> Index()
        {
            var response = await httpClient.GetAsync("http://localhost:8080/api/Employee");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var employees = new List<Employee>();
            if(response.Content.Headers.ContentType.MediaType == "application/json")
            {
                employees = JsonConvert.DeserializeObject<List<Employee>>(content);
            }
            return View(employees);
        }

        public  ActionResult UpdateEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateEmployee(Employee emp)
        {
            var response = await
        }

        
    }
}
