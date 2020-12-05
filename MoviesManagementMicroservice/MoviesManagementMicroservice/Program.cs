using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MoviesManagementMicroservice.Data;
using MoviesManagementMicroservice.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesManagementMicroservice
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // await DataScraping.GetImdbMoviePosterUrlAsync(114709);

            //DataContext.ImportLinkDataFromCsv();

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
