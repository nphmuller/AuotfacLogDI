using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Autofac.Extensions.DependencyInjection;

namespace AutofacLogDI
{
    public class Program
    {
        public static void Main() => BuildWebHost().Run();

        public static IWebHost BuildWebHost() =>
            WebHost.CreateDefaultBuilder()
                .ConfigureServices(s => s.AddAutofac())
                .UseStartup<Startup>()
                .Build();
    }
}
