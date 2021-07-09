using System;
using System.Collections.Generic;
using System.Text;

namespace HelloCrowe.Services
{
    /// <summary>
    /// Interface for Hello World Service
    /// </summary>
    public interface IHelloWorldService
    {
        string GetHello(string name = null);
    }
}
