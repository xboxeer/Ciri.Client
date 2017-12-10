using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiriDemo.Classes
{
    public interface IMessageProvider
    {
        string Reply(string incomingMessage);
    }
}
