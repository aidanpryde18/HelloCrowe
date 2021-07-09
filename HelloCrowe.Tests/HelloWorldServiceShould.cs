using HelloCrowe.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloCrowe.Tests
{
    [TestClass]
    public class HelloWorldServiceShould
    {
        private readonly HelloWorldService helloService = new();

        [TestMethod]
        public void WhenGivenNoParameterReturnHelloWorld()
        {
            var expectedString = "Hello World";

            var actualString = helloService.GetHello();

            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod]
        public void WhenGivenNameParameterReturnHelloName()
        {
            var name = "Billy";
            var expectedString = $"Hello {name}";

            var actualString = helloService.GetHello(name);

            Assert.AreEqual(expectedString, actualString);
        }
    }
}
