using Microsoft.AspNetCore.Hosting;
using Obligatorisk_OPG.Services.Interfaces;
using Obligatorisk_OPG.Services.MockServices.MockDormitoryService;

namespace Obligatorisk_OPG
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}