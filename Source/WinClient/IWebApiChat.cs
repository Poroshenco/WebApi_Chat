using System.Threading.Tasks;
using Refit;
using WebApiChat.Core.Models;

namespace WinClient
{
    public interface IWebApiChat
    {
        [Get("/message")]
        Task<Message[]> GetMessages(long startId, int count);

        [Get("/user/register")]
        Task<LoginInfo> Register(string login, string password);

        [Get("/user/login")]
        Task<LoginInfo> Login(string login, string password);
    }
}