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

            SayHello(helloService);
        }

        /// <summary>
        /// Gets the Hello String and outputs it to the console
        /// </summary>
        /// <param name="helloService">
        /// Service called to get the Hello string
        /// </param>
        private static void SayHello(IHelloWorldService helloService)
        {
            var output = helloService.GetHello();

            Console.WriteLine(output);
        }

        /// <summary>
        /// Builder method for DI Container and other needs as required
        /// </summary>
        /// <returns>
        /// A configured Host instance
        /// </returns>
        static IHost AppStartup()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<IHelloWorldService, HelloWorldService>();
                })
                .Build();
        }
    }
}
