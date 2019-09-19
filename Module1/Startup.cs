using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using OrchardCore.Modules;
using System;

namespace Module1
{
    public class Startup : StartupBase
    {
         public override void Configure(IApplicationBuilder app, IRouteBuilder routes, IServiceProvider serviceProvider)
         {
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
            //app.Map("/hello", branch =>
            //    branch.Run(context => context.Response.WriteAsync("Hello World"))
            //);
            routes.MapAreaRoute("Module1Name", "Module1", "", new { controller = "About", action = "Index" });
        }
    }
}
