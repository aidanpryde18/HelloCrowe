using System;
using System.Collections.Generic;
using System.Text;

namespace HelloCrowe.Services
{
    public interface IHelloWorldService
    {
        string GetOutputString(string name = null);
    }
}
