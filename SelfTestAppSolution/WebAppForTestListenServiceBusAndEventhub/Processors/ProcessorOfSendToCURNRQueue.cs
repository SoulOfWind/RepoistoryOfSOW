using Azure.Messaging.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppForTestListenServiceBusAndEventhub.Processors
{
    

    public class ProcessorOfSendToCURNRQueue
    {
        private ServiceBusProcessor Processor { get; set; }


        public void Init(ServiceBusClient client)
        {
            var queueName = "testrealNameVerifyQueue";
            ServiceBusProcessor processor = client.CreateProcessor(queueName, new ServiceBusProcessorOptions() { MaxConcurrentCalls = 1 });
            processor.ProcessMessageAsync += MessageHandler;
            processor.ProcessErrorAsync += ErrorHandler;
            Processor = processor;//赋值给属性
        }

        public async Task StartProcessorAsync()
        {
            await Processor.StartProcessingAsync();
        }

        public async Task StopProcessorAsync()
        {
            await Processor.StopProcessingAsync();
        }
        public Task ErrorHandler(Azure.Messaging.ServiceBus.ProcessErrorEventArgs args)
        {
            Console.WriteLine(args.Exception.ToString());
            return Task.CompletedTask;
        }
        public async Task MessageHandler(ProcessMessageEventArgs args)
        {
            // handle any errors when receiving messages
            try
            {
                string body = args.Message.Body.ToString();
                Console.WriteLine($"Received: {body}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                await args.AbandonMessageAsync(args.Message);
            }
            // complete the message. messages is deleted from the queue. 
            await args.CompleteMessageAsync(args.Message);

        }
    }
}
