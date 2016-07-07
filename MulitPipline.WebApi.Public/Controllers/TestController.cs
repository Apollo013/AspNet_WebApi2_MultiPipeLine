using System.Web.Http;

namespace MulitPipline.WebApi.Public.Controllers
{
    [RoutePrefix("test")]
    public class TestController : PublicBaseController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok("Hello from Public Pipeline");
        }
    }
}
