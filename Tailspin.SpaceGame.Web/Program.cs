// JJP updated Program.cd on 2024-08-07
using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace TailSpin.SpaceGame.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static void JJPNewFunction1(string[] args)
        {
            Console.WriteLine("JJP added a function to Progra.cs into feature/myJJPFeature-6 branch");
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
