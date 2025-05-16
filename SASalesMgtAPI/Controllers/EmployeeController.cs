using Microsoft.AspNetCore.Mvc;
using SASalesMgtAPI.Models.Dictionary;

namespace SASalesMgtAPI.Controllers
{
    [Route("/api/Employees")]
    [ApiController]
    public class EmployeeController : Controller
    {
        [HttpGet]
        [Route("/SalesPersonList")]
        public ActionResult<IList<DictionaryItem>> GetSalesPersons()
        {
            IList<DictionaryItem> list = new List<DictionaryItem>();
            return Ok(list);
        }
    }
}
