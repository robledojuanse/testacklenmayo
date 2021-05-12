using Microsoft.VisualStudio.TestTools.UnitTesting;
using consoleappacklen;


namespace testproject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSuccess()
        {

            Program objClass = new Program();

            var res = objClass.testStrings("testsebas");

            Assert.AreEqual("testsebas", res);
        }

        [TestMethod]
        public void TestMethodError()
        {

            Program objClass = new Program();

            var res = objClass.testStrings("testsebas2");

            Assert.AreEqual("testsebas", res);
        }
    }
}
