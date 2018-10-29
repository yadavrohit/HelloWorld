using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Logic
{
    internal class HelloWorldWinService : HelloWorldBase, IHelloWorld
    {
        public HelloWorldWinService(HelloWorldRepository repository)
            : base(repository, HelloWorldClient.WIN_SERVICE)
        {

        }

        public string getGreeting()
        {
            return "Hello " + this.client.ToString();
        }

        public void setGreeting(string greeting)
        {
            this.repository.update(greeting);
        }
    }
}
