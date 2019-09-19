using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Environment.Shell;
using OrchardCore.Modules;
using System;

namespace Ward
{
    public class Startup : StartupBase
    {
        public override void Configure(IApplicationBuilder app, IRouteBuilder routes, IServiceProvider serviceProvider)
        {
            routes.MapAreaRoute("WardModule", "Ward", "", new { controller = "Home", action = "Index" });
        }
    }
}
