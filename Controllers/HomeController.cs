using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        //Verificar se a API está online.
        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
