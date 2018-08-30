using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Vote.App.Areas.Identity.IdentityHostingStartup))]

namespace Vote.App.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}