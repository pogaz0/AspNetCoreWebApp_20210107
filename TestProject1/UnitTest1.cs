using NUnit.Framework;
using System.IO;
using System;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();

            //using (var sw = new StringWriter())
            //{
            //    Console.SetOut(sw);
            //    AspNetCoreWebApp_20210107.Program.Main();

            //    var result = sw.ToString().Trim();
            //    Assert.AreEqual(Expected, result);
            //}
        }
    }
}