using Azure.Messaging.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppForTestListenServiceBusAndEventhub.Senders
{
    public class SenderOfTestDWHTopic
    {

        private ServiceBusSender Sender { get; set; }
        public void Init(ServiceBusClient client)
        {
            var queueName = "testdwhtopic";
            ServiceBusSender sender = client.CreateSender(queueName);
            Sender = sender;
        }

        public async Task SendMessageAsync(ServiceBusMessage msg)
        {

            await Sender.SendMessageAsync(msg);
        }



    }
}
