using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Logic
{
    internal class HelloWorldRepository
    {
        private string _connectionString;
        public HelloWorldRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void update(string greeting)
        {
            throw new NotImplementedException(string.Format("This code is incomplete."));
        }
    }
}
