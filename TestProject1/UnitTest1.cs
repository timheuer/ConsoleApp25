using System.Globalization;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ResourcesArePublic()
        {
            Assert.IsTrue(typeof(ConsoleApp25.Resources).IsVisible);
        }

        [TestMethod]
        public void GermanTranslationWorks()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
            Assert.AreEqual(ConsoleApp25.Resources.SomeString, "Hallo welt");
        }
    }
}
