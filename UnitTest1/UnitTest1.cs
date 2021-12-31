using FluentBuilder2_UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Greet greeting = GreetingBuilder
                .CreateNew()
                .TimeOfDay("Noches")
                .To("Rodrigo")
                .Build();

            Assert.AreEqual($"Buenas Noches Rodrigo", greeting.Message);
        }
    }
}
