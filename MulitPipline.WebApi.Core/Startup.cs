using Microsoft.Owin;
using MulitPipline.WebApi.Admin.Controllers;
using MulitPipline.WebApi.Core.Providers;
using MulitPipline.WebApi.Core.Resolvers;
using MulitPipline.WebApi.Public.Controllers;
using Owin;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

[assembly: OwinStartup(typeof(MulitPipline.WebApi.Core.Startup))]

namespace MulitPipline.WebApi.Core
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888

            /*
             * CONFIGURE PUBLIC PIPELINE
             */
            app.Map("/public", map =>
            {
                var config = CreateTypedConfiguration<PublicBaseController>();
                map.UseWebApi(config);
            });

            /*
             * CONFIGURE ADMIN PIPELINE
             */
            app.Map("/admin", map =>
            {
                var config = CreateTypedConfiguration<AdminBaseController>();
                map.UseWebApi(config);
            });

        }

        /// <summary>
        /// Creates a HttpConfiguration object for each pipline
        /// </summary>
        /// <typeparam name="TBaseController">Defines the base type of the controllers to use for the pipeline</typeparam>
        /// <returns></returns>         
        private static HttpConfiguration CreateTypedConfiguration<TBaseController>() where TBaseController : IHttpController
        {
            var config = new HttpConfiguration();

            config.Services.Replace(typeof(IHttpControllerTypeResolver), new TypedHttpControllerTypeResolver<TBaseController>());
            config.MapHttpAttributeRoutes(new TypedDirectRouteProvider<TBaseController>());

            return config;
        }

    }
}
