using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Logic
{
    public class HelloWorldFactory
    {
        private static string _connectionString = null;

        public static void Init(string connectionString)
        {
            _connectionString = connectionString;
        }

        public static IHelloWorld CreateInstance(HelloWorldClient client, string connectionString)
        {
            HelloWorldRepository repository = new HelloWorldRepository(connectionString);
            switch (client)
            {
                case HelloWorldClient.CONSOLE:
                    return new HelloWorldConsole(repository);
                case HelloWorldClient.WEB:
                    return new HelloWorldWeb(repository);
                case HelloWorldClient.MOBILE:
                    return new HelloWorldMobile(repository);
                case HelloWorldClient.WIN_SERVICE:
                    return new HelloWorldWinService(repository);
                default:
                    throw new NotImplementedException(string.Format("Unknown Client : {0} ", client));
            }
        }
    }
}
