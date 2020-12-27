using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace DyCompanyName.DyProjectName
{
    public class DyProjectNameWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<DyProjectNameWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}