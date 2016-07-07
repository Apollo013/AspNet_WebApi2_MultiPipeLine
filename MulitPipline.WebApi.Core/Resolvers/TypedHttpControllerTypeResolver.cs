using System;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace MulitPipline.WebApi.Core.Resolvers
{
    /// <summary>
    /// Resolves which controllers to use for each pipeline
    /// </summary>
    /// <typeparam name="TBaseController"></typeparam>
    public class TypedHttpControllerTypeResolver <TBaseController> : DefaultHttpControllerTypeResolver where TBaseController: IHttpController
    {
        public TypedHttpControllerTypeResolver() : base(IsController) { }

        /// <summary>
        /// Constraint used to discover controllers
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        internal static bool IsController(Type t)
        {
            if (t == null) throw new ArgumentNullException("t");

            return
                t.IsClass &&                                    // Must be a class
                t.IsVisible &&                                  // Must be public
                !t.IsAbstract &&                                // Must not be abstract
                typeof(TBaseController).IsAssignableFrom(t);    // Base class must match our predefined base controller
        }
    }
}
