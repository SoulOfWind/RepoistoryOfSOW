using Btc.Swagger;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppForTestAspDotNetCoreMVC.Controllers
{
    [ApiController]
    [BtcSwaggerTag("Test")]
    [ApiVersion("1.0")]
    [Route("Test")]
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("TestGet")]
        public async Task<string> TestGet() {
            return await Task.FromResult("Success");
        }
    }
}
