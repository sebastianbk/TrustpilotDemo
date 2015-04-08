using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace TrustpilotDemo
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<Repositories.IBlogRepo, Repositories.BlogRepo>()
                .AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc().UseStaticFiles();
        }
    }
}
