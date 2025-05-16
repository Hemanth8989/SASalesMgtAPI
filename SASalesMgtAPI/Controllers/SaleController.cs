using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SASalesMgtAPI.Models;
namespace SASalesMgtAPI.Controllers
{
    public class SaleController :Controller
    {

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IList<Sale>> GetSaleList(string startDate,string endDate,int typeID,int statusID,int userID,int locID,string search)
        {
            IList<Sale> list = new List<Sale>();

            return Ok(list);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<int> ActSaveSaleOrder([FromBody] Object order)
        {
            return Ok();
        }

    }
}
