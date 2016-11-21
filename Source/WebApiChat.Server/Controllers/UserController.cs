using System;
using System.Web.Http;
using WebApiChat.Core.Models;

namespace WebApiChat.Server.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        public LoginInfo Register(string login, string password)
        {
            return new LoginInfo
            {
                AccessToken = Guid.NewGuid().ToString()
            };
        }

        public LoginInfo Login(string login, string password)
        {
            return new LoginInfo
            {
                AccessToken = Guid.NewGuid().ToString()
            };
        }
    }
}