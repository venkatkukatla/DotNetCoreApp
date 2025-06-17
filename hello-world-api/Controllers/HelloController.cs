// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;

// namespace hello_world_api.Controllers
// {
//     [Route("api/[controller]")]
//     public class HelloController : Controller
//     {
//         // GET api/helllo
//         [HttpGet]
//         public string Get()
//         {
//             return "Hello world!!!!!!";
//         }

//     }
// }


// using Microsoft.AspNetCore.Mvc;

// namespace hello_world_api.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class HelloController : ControllerBase
//     {
//         [HttpGet]
//         public IActionResult Get()
//         {
//             return Ok("Hello world!");
//         }
//     }
// }



using Microsoft.AspNetCore.Mvc;

namespace hello_world_api.Controllers
{
    [ApiController]
    [Route("/")] // 👈 This maps it to the root URL
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Welcome to DevOps World!";
        }
    }
}
