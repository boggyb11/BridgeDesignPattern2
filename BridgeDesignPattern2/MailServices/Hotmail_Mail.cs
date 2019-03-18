using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern2
{
    class Hotmail_Mail : IMessage
    {
        public void Send()
        {
            Console.WriteLine("Sent a hotmail mail");
        }
    }
}
