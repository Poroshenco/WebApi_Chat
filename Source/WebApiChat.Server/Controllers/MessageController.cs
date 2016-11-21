using System.Web.Http;

namespace WebApiChat.Server.Controllers
{
    public class MessageController : ApiController
    {
        #region public methods

        public string Get()
        {
            return "hi";
        }

        #endregion
    }
}