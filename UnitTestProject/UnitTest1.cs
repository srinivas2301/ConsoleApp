using NUnit.Framework;
using System.IO;
using System;

namespace UnitTestProject
{
    public class Tests
    {
        //[SetUp]
        //public class Setup()
        //    {
            private const string Expected = "Hello World from srinivas";
    
    
        [Test]
        public void Test1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                ConsoleApp.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
                Assert.Pass();
            }
        }
    }

}