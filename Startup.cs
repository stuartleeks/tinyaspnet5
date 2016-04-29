using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace EmptyWeb
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseWelcomePage();
        }
        
        
         // Entry point for the application.
        public static void Main(string[] args)
        {
            // var config = new ConfigurationBuilder()
            //             .AddCommandLine(args)
            //             .Build();
                        
            var host = new WebHostBuilder()
                // // .UseDefaultHostingConfiguration(args)
                // .UseConfiguration(config)
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseUrls("http://0.0.0.0:5000")
                .Build();

            host.Run();
        }
    }
}
