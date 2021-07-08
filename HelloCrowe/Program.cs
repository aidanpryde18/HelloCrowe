using HelloCrowe.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace HelloCrowe
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = AppStartup();            

            var helloService = host.Services.GetService<IHelloWorldService>();

            var output = helloService.GetOutputString();

            Console.WriteLine(output);
        }

        static IHost AppStartup()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<IHelloWorldService, HelloWorldService>();
                })
                .Build();

            return host;
        }
    }
}
