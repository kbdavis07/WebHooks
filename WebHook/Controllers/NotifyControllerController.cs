using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebHook.Models;

namespace WebHook.Controllers
{
    [Authorize]
    public class NotifyController : Controller
    {
        [HttpPost]
        public async Task<ActionResult> Submit()
        {
            Transaction NewTransaction = new Transaction
            {
                Id = 1,
                OrderID = 1,
                OrderDate = DateTime.Now,
                OrderTotal = 20.00m,
                Status = "Created"
            
            };

          
            // Create an event with action 'event1' and additional data
            await this.NotifyAsync("event1", new { P1 = NewTransaction });

            return new EmptyResult();
        }
    }
}