using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SettingsManagerWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralController : ControllerBase
    {
        // GET api/values
        [HttpGet, Route("test")]
        public string test()
        {
            return "Hello World!";
        }


    }
}
