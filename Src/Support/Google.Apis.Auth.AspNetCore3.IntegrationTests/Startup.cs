/*
Copyright 2020 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Google.Apis.Auth.AspNetCore3.IntegrationTests
{
    // TODO: Make this more ASP.NET Core 3 idiomatic; rather than the current conversion from ASP.NET Core 2.

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie()
                .AddGoogleOpenIdConnect(options =>
                {
                    var clientInfo = (ClientInfo)services.First(x => x.ServiceType == typeof(ClientInfo)).ImplementationInstance;
                    options.ClientId = clientInfo.ClientId;
                    options.ClientSecret = clientInfo.ClientSecret;
                });
            services.AddMvc(o => o.EnableEndpointRouting = false);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseAuthentication();
            app.UseMvc(routes => routes.MapRoute("home", "{controller=Home}/{action=Index}"));

            if (env.EnvironmentName.ToLowerInvariant() == "development")
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) => await context.Response.WriteAsync("Fallback, probably shouldn't get here."));
        }
    }
}
