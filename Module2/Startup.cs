using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Environment.Shell;
using OrchardCore.Modules;
using System;

namespace Module2
{
    public class Startup : StartupBase
    {
        public override void Configure(IApplicationBuilder app, IRouteBuilder routes, IServiceProvider serviceProvider)
        {
            //app.Map("/info", branch =>
            //    branch.Run(context => context.Response.WriteAsync("Hello World Module 2"))
            //);
            app.Map("/module2", branch =>
            {
                branch.Run(context =>
                {
                    var shellSettings = context.RequestServices.GetRequiredService<ShellSettings>();
                    return context.Response.WriteAsync($"Request from tenant: {shellSettings.Name}");
                });
            });
            //routes.MapAreaRoute("Module1Name", "Module3", "", new { controller = "About", action = "Index" });

        }
    }
}
