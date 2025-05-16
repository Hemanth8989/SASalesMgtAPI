using Microsoft.AspNetCore.Mvc;
using SASalesMgtAPI.Models.Dictionary;

namespace SASalesMgtAPI.Controllers
{
    [Route("api/Inventory")]
    public class InventoryController : Controller
    {
        [HttpGet]
        [Route("/DictionaryList")]
        public ActionResult<IList<DictionaryItem>> GetInventoryDictionaryList(int typeID)
        {
            IList<DictionaryItem> list = new List<DictionaryItem>();
            return Ok(list);
        }
        [HttpGet]
        [Route("/ProductGroups")]
        public ActionResult<IList<DictionaryItem>> GetProductGroups()
        {
            //typeid != 2
            IList<DictionaryItem> list = new List<DictionaryItem>();
            return Ok(list);
        }
    }
}
