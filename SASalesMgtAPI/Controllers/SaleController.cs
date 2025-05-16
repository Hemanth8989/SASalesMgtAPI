using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SASalesMgtAPI.Models;
namespace SASalesMgtAPI.Controllers
{
    public class SaleController :Controller
    {

        [HttpGet]
        public ActionResult<IList<Sale>> GetSaleList(string startDate,string endDate,int typeID,int statusID,int userID,int locID,string search)
        {
            IList<Sale> list = new List<Sale>();

            return Ok(list);
        }
        [HttpPost]
        public ActionResult<int> ActSaveSaleOrder(SaleOrderNew saleOrder)
        {
            return Ok();
        }
        

    }
}
