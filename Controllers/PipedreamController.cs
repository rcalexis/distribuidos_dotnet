using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Distribuidos.Api.Models; 
using Distribuidos.Api.Services;  

namespace Distribuidos.Api.Controllers
{
    [Route("api/pipedream")]
    [ApiController]
    public class PipedreamController : Controller
    {
        private readonly IPipedreamService _pipedreamService;
        
        public PipedreamController(IPipedreamService pipedreamService)
        {
            _pipedreamService = pipedreamService;
        }

        [HttpPost("welcome")]
        public async Task<IActionResult> WelcomeEmail([FromBody] WelcomeModel body)
        {
            try
            {
                bool result = await _pipedreamService.SendWelcome(body);

                return Ok(new
                {
                    error = false,
                    msj = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    error = true,
                    msj = ex.Message
                });
            }
        }
    }
}

// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;

// namespace Distribuidos.Api.Controllers
// {
//     [Route("api/pipedream")]
//     [ApiController]
//     public class PipedreamController : Controller
//     {
//         private readonly IPipedreamService _pipedreamService;
//         public PipedreamController(IPipedreamService pipedreamService)
//         {
//             _pipedreamService = pipedreamService;

//         }

//         [HttpPost("welcome")]
//         public async Task<IActionResult> WelcomeEmail([FromBody] WelcomeModel body)
//         {
//             try
//             {
//                 bool result = await _pipedreamService.SendWelcome(body);

//                 return Ok({
//                     error = false,
//                     msj = result
//                 });


//             }
//             catch (Exception ex)
//             {

//                 return BadRequest(new
//                 {
//                     error = true,
//                     msj = ex.Message
//                 });
//             }
//         }
//     }
// }
