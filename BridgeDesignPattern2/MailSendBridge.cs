using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern2
{
    class MailSendBridge
    {
        public void SendFrom(IMessage mailService)
        {
            mailService.Send();
        }
    }
}
