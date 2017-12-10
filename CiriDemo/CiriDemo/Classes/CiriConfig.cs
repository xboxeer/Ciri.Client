using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiriDemo.Classes
{
    public class CiriConfig
    {
        public IMessageProvider GetMessageProvider()
        {
            return new MockMessageProvider();
        }
    }
}
