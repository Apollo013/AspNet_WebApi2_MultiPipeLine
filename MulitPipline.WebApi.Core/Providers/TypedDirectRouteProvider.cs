using System.Collections.Generic;
using System.Web.Http.Controllers;
using System.Web.Http.Routing;

namespace MulitPipline.WebApi.Core.Providers
{
    /// <summary>
    /// Maps route attributes specific to a predefined base controller class
    /// </summary>
    /// <typeparam name="TBaseController">Defines the base type of the controllers to use for mapping routes</typeparam>
    public class TypedDirectRouteProvider<TBaseController> : DefaultDirectRouteProvider where TBaseController : IHttpController
    {
        public override IReadOnlyList<RouteEntry> GetDirectRoutes(HttpControllerDescriptor controllerDescriptor, IReadOnlyList<HttpActionDescriptor> actionDescriptors, IInlineConstraintResolver constraintResolver)
        {
            if (typeof(TBaseController).IsAssignableFrom(controllerDescriptor.ControllerType))
            {
                var routes = base.GetDirectRoutes(controllerDescriptor, actionDescriptors, constraintResolver);
                return routes;
            }
            return new RouteEntry[0];
        }
    }
}
