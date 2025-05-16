using Microsoft.AspNetCore.Mvc;
using SASalesMgtAPI.Models.Dictionary;

namespace SASalesMgtAPI.Controllers
{
    [Route("api/Dictionary")]
    [ApiController]
    public class DictionaryController : Controller
    {
        [HttpGet]
        public ActionResult<IList<DictionaryItem>> GetMasterDictionaryList(int typeID)
        {
            IList<DictionaryItem> list = new List<DictionaryItem>();
            return Ok(list);
        }

        [HttpGet]
        [Route("GetDates")]
        public ActionResult GetDates(string period)
        {

            return Ok();
        }
    }

}
