using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Logic
{
    internal class HelloWorldBase
    {
        protected HelloWorldRepository repository { get; set; }

        protected HelloWorldClient client { get; set; }

        public HelloWorldBase(HelloWorldRepository repository, HelloWorldClient client)
        {
            this.client = client;
            this.repository = repository;
        }

        /*Contains all common logic or code shared by all clients*/
    }
}
