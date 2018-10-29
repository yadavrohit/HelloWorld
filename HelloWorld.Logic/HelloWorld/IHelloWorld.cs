using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Logic
{
    public interface IHelloWorld
    {
        string getGreeting();
        void setGreeting(string greeting);
    }
}
