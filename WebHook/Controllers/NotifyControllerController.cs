using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            var Cookie = Request.Cookies["TEFLUK"].Value;

            string decodedUrl = HttpUtility.UrlDecode(Cookie);

            var CookieJson = JsonConvert.DeserializeObject< TAUserInfo>(decodedUrl);
            
            //var Cookie = JsonConvert.DeserializeObject(Request.Cookies["TEFLUK"].Value);

            Transaction NewTransaction = new Transaction
            {
                Id = 1,
                OrderID = 1,
                DeviceHash = CookieJson.DeviceHash,
                OrderDate = DateTime.Now,
                OrderTotal = 20.00m,
                Status = "Created"
            
            };

          
            // Create an event with action 'event1' and additional data
            await this.NotifyAsync("New_Order", new { Transaction = NewTransaction, CookieJson});

            return new EmptyResult();
        }
    }
}