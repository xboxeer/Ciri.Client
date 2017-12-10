using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiriDemo.Classes
{
    public class MockMessageProvider:IMessageProvider
    {
        public string Reply(string incomingMessage)
        {
            throw new NotImplementedException();
        }
    }
}
