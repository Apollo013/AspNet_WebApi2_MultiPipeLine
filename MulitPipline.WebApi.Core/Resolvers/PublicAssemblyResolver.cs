using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Http.Dispatcher;

namespace MulitPipline.WebApi.Core.Resolvers
{
    public class PublicAssemblyResolver : IAssembliesResolver
    {
        public ICollection<Assembly> GetAssemblies()
        {
            ICollection<Assembly> baseAssemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();
            List<Assembly> assemblies = new List<Assembly>(baseAssemblies);
            var controllersAssembly = Assembly.LoadFrom(@"C:\Apps\App Tests\WEBAPI\MulitPipline\MulitPipline.WebApi.Public\bin\Debug\MulitPipline.WebApi.Public.dll");
            assemblies.Add(controllersAssembly);
            return assemblies;
        }
    }
}
