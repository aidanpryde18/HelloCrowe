using System;

namespace HelloCrowe.Services
{
    /// <summary>
    /// Service for Hello World functionality
    /// </summary>
    public class HelloWorldService : IHelloWorldService
    {
        /// <summary>
        /// Returns the Hello World output string, based on input parameter.
        /// </summary>
        /// <param name="name">
        /// Name of person to be greeted. Can be null
        /// </param>
        /// <returns>
        /// Output string, either generic or personalized, based on input parameters
        /// </returns>
        public string GetHello(string name = null) => name != null ? $"Hello {name}" : "Hello World";
    }
}
