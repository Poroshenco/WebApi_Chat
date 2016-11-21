using System;
using System.Reflection;
using System.Web.Http;
using Microsoft.Owin;
using Owin;
using WebApiChat.Server;

[assembly: OwinStartup(typeof(Startup))]

namespace WebApiChat.Server
{
    public class Startup
    {
        #region public methods

        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new {id = RouteParameter.Optional}
                );

            app.UseWebApi(config);

            app.Run(context =>
            {
                context.Response.ContentType = "text/plain";
                //var output = string.Empty;
                var output = string.Format(
                    "I'm running on {0} \nFrom assembly {1}",
                    Environment.OSVersion,
                    Assembly.GetEntryAssembly().FullName
                    );

                return context.Response.WriteAsync(output);
            });
        }

        #endregion
    }
}