using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWorkout.Web.Hosting;
using MyWorkout.Dal;

namespace MyWorkout.Web
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            (await CreateHostBuilder(args)
                .Build()
                .MigrateDataBaseAsync<MyWorkoutDbContext>())
                .Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
