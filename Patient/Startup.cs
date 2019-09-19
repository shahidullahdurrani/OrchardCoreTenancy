using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using OrchardCore.Modules;
using System;

namespace Patient
{
    public class Startup : StartupBase
    {
        public override void Configure(IApplicationBuilder app, IRouteBuilder routes, IServiceProvider serviceProvider)
        {
            routes.MapAreaRoute("PatientModule", "Patient", "", new { controller = "Home", action = "Index" });
        }
    }
}
