using Microsoft.AspNetCore.Mvc;
using SASalesMgtAPI.Models.Dictionary;

namespace SASalesMgtAPI.Controllers
{
    [Route("api/QuoteAdmin")]
    [ApiController]
    public class QuoteAdminController : Controller
    {
        [HttpGet]
        public ActionResult<IList<DictionaryItem>> GetPriceList(int typeID)
        {
            IList<DictionaryItem> list = new List<DictionaryItem>();
            return Ok(list);
        }
    }
}
