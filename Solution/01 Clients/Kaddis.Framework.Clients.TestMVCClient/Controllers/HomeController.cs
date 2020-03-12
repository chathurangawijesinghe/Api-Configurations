using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Kaddis.Framework.Clients.TestMVCClient.Models;
using Grpc.Net.Client;
using Kaddis.Framework.Clients.TestMVCClient.Protos;

namespace Kaddis.Framework.Clients.TestMVCClient.Controllers
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
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Tester.TesterClient(channel);
            var reply = client.GetTests(
                              new TestRequest { OrderBy = "1" });

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
