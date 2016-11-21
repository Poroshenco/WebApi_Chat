using System.Web.Http;

namespace WebApiChat.Server.Controllers
{
    public class MessageController : ApiController
    {
        public string Get()
        {
            return "hi";
        }
    }
}