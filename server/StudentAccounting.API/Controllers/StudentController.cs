using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace StudentAccounting.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        public StudentController(ILogger<StudentController> logger)
        {
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://google.com");
            if (response.IsSuccessStatusCode) return Ok();
            return BadRequest();
        }
    }
}