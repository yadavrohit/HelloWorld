using HelloWorld.Logic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.AppSettings["connectionString"];
            HelloWorldFactory.Init(connectionString);
            var hwInstance = HelloWorldFactory.CreateInstance(HelloWorldClient.CONSOLE, connectionString);
            hwInstance.getGreeting();
            Console.WriteLine(string.Format("Greetings from console : {0}", hwInstance.getGreeting()));
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
