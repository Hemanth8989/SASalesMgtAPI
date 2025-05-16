using Microsoft.AspNetCore.Mvc;
using SASalesMgtAPI.Models.Dictionary;

namespace SASalesMgtAPI.Controllers
{
    [Route("/Admin")]
    [ApiController]
    public class AdminController : Controller
    {
        [HttpGet]
        [HttpGet("currency/symbol")]
        public ActionResult<string> GetCurrencySymbol()
        {
            return Ok("$");
        }
    }
}
