using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Azure.Identity;
using System;

namespace PRO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).ConfigureAppConfiguration((hostContext, builder) =>
            {
                // Add other providers for JSON, etc.

                if (hostContext.HostingEnvironment.IsDevelopment())
                {
                    builder.AddUserSecrets<Program>();
                }
            })
                .Build().Run();
        }

        //Azure config
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
.ConfigureAppConfiguration((context, config) =>
{
    var keyVaultEndpoint = new Uri(Environment.GetEnvironmentVariable("VaultUri"));
    config.AddAzureKeyVault(keyVaultEndpoint, new DefaultAzureCredential());
})
                .ConfigureWebHostDefaults(webBuilder =>
                 webBuilder.ConfigureAppConfiguration((hostingContext, config) =>
                 {
                     var settings = config.Build();

                     config.AddAzureAppConfiguration(options =>
                     {
                         options.Connect(settings["ConnectionStrings:AppConfig"])
                                 .ConfigureKeyVault(kv =>
                                 {
                                     kv.SetCredential(new DefaultAzureCredential(false));
                                 });
                     });
                 })
                    .UseStartup<Startup>());

        //Standard config
        /*
                    public static IHostBuilder CreateHostBuilder(string[] args) =>
                    Host.CreateDefaultBuilder(args)
                        .ConfigureWebHostDefaults(webBuilder =>
                        {
                            webBuilder.UseStartup<Startup>();
                        });
            */
    }
}
