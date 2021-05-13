using System;
using Xunit;
using dotnetcore;

namespace PrimeService.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Testsuccess()
        {
            Program objClass = new Program();

            var res = objClass.testData("sebas");

            Assert.Contains("sebastest", res);

        }

        [Fact]
        public void Testfail()
        {
            Program objClass = new Program();

            var res = objClass.testData("sebas");

            Assert.Contains("sebastest", res);

        }
    }
}
