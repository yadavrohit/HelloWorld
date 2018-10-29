using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.Logic;

namespace HelloWorld.Tests
{
    [TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void test_create_console_type()
        {
            var client = HelloWorldClient.CONSOLE;
            var connectionString = "DB Connection string";
            HelloWorldFactory.Init(connectionString);
            var hwInstance = HelloWorldFactory.CreateInstance(client, connectionString);
            Assert.AreEqual(hwInstance.getGreeting(), "Hello " + client.ToString());
        }
        [TestMethod]
        public void test_create_web_type()
        {
            var client = HelloWorldClient.WEB;
          var connectionString = "DB Connection string";
            HelloWorldFactory.Init(connectionString);
            var hwInstance = HelloWorldFactory.CreateInstance(client, connectionString);
            Assert.AreEqual(hwInstance.getGreeting(), "Hello " + client.ToString());
        }

        [TestMethod]
        public void test_create_winservice_type()
        {
            var client = HelloWorldClient.WIN_SERVICE;
          var connectionString = "DB Connection string";
            HelloWorldFactory.Init(connectionString);
            var hwInstance = HelloWorldFactory.CreateInstance(client, connectionString);
            Assert.AreEqual(hwInstance.getGreeting(), "Hello " + client.ToString());
        }

        [TestMethod]
        public void test_create_mobile_type()
        {
            var client = HelloWorldClient.MOBILE;
          var connectionString = "DB Connection string";
            HelloWorldFactory.Init(connectionString);
            var hwInstance = HelloWorldFactory.CreateInstance(client, connectionString);
            Assert.AreEqual(hwInstance.getGreeting(), "Hello " + client.ToString());
        }
        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void test_client_not_implemented()
        {
            var client = HelloWorldClient.NEW_CLIENT;
          var connectionString = "DB Connection string";
            HelloWorldFactory.Init(connectionString);
            HelloWorldFactory.CreateInstance(client, connectionString);
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void test_write_on_implemented_client()
        {
            var client = HelloWorldClient.MOBILE;
          var connectionString = "DB Connection string";
            HelloWorldFactory.Init(connectionString);
            var hwInstance = HelloWorldFactory.CreateInstance(client, connectionString);
            hwInstance.setGreeting("Test");

        }
    }
}
