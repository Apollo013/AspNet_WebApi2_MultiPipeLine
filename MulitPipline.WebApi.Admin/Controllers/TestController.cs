using System.Web.Http;

namespace MulitPipline.WebApi.Admin.Controllers
{
    [RoutePrefix("test")]
    public class TestController : AdminBaseController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok("Hello from Admin Pipeline");
        }
    }
}
