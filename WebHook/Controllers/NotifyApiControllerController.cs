using System.Threading.Tasks;
using System.Web.Http;


namespace WebHook.Controllers
{
    [Authorize]
    public class NotifyApiController : ApiController
    {
        public async Task Post()
        {
            // Create an event with 'event2' and additional data
            await this.NotifyAsync("event2", new { P1 = "p1" });
        }
    }
}