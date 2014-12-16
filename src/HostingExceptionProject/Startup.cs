using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace HostingExceptionProject
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseWelcomePage();
        }
    }
}
