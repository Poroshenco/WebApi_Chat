using System;
using Microsoft.Owin.Hosting;

namespace WebApiChat.Server
{
    internal class Program
    {
        #region private methods

        private static void Main(string[] args)
        {
            var baseUrl = "http://*:5000/";
            using (WebApp.Start<Startup>(baseUrl))
            {
                Console.ReadKey();
            }
        }

        #endregion
    }
}