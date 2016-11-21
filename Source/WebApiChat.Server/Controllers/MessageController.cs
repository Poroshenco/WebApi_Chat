using System.Web.Http;
using WebApiChat.Core.Models;

namespace WebApiChat.Server.Controllers
{
    public class MessageController : ApiController
    {
        public Message[] Get(long startId, int count)
        {
            return new Message[5];
        }
    }
}