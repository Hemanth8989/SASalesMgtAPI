using Microsoft.AspNetCore.Mvc;
using SASalesMgtAPI.Models;
using SASalesMgtAPI.Models.Dictionary;

namespace SASalesMgtAPI.Controllers
{
    [Route("api/Customer")]
    [ApiController]
    public class CustomerController : Controller
    {
        [HttpGet]
        [Route("CustomerList")]
        public ActionResult<IList<Customer>> GetCustomerList()
        {
            IList<DictionaryItem> list = new List<DictionaryItem>();
            return Ok(list);
        }
        [HttpGet]
        [Route("CustomerList/{typeID:int}")]
        public ActionResult<IList<DictionaryItem>> GetCustomerList(int typeID)
        {
            IList<DictionaryItem> list = new List<DictionaryItem>();
            return Ok(list);
        }
        [HttpGet]
        [Route("DictionaryList/{typeID:int}")]
        public ActionResult<IList<DictionaryItem>> GetDictionaryList(int typeID)
        {
            IList<DictionaryItem> list = new List<DictionaryItem>();
            return Ok(list);
        }
        [HttpGet]
        [Route("CustomerAddress/{typeID:int}")]
        public ActionResult<IList<DictionaryItem>> GetCustomerAddress(int custID)
        {
            IList<DictionaryItem> list = new List<DictionaryItem>();
            return Ok(list);
        }
    }
}
