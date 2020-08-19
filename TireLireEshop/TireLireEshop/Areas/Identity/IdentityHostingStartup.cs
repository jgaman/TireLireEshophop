using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TireLireEshop.Data;

[assembly: HostingStartup(typeof(TireLireEshop.Areas.Identity.IdentityHostingStartup))]
namespace TireLireEshop.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            //builder.ConfigureServices((context, services) => {
            //    services.AddDbContext<SecuriteContext>(options =>
            //        options.UseSqlServer(
            //            context.Configuration.GetConnectionString("DefaultConnection")));

            //    services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //        .AddEntityFrameworkStores<SecuriteContext>();
            //});
        }
    }
}