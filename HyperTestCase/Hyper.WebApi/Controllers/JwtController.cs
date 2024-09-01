using Hyper.WebApi.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hyper.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JwtController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public JwtController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("[action]")]
        public IActionResult GetTokenForVisitor()
        {
            Token token = TokenHandler.CreateTokenToVisitor(_configuration);
            return Ok(token);
        }

        [HttpGet("[action]")]
        public IActionResult GetTokenForAdmin()
        {
            Token token = TokenHandler.CreateTokenToAdmin(_configuration);
            return Ok(token);
        }
    }
}
