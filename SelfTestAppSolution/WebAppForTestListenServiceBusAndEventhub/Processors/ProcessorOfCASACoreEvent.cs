using Azure.Messaging.EventHubs;
using Azure.Messaging.EventHubs.Processor;
using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppForTestListenServiceBusAndEventhub.Processors
{
    public class ProcessorOfCASACoreEvent
    {

        private string eventhubNamespaceConnectionString = "Endpoint=sb://btccndev-state-core-ingress-event-hubs.servicebus.chinacloudapi.cn/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=We0KCdQD0DS2jdJa4faWI5AY/gCjimeC3Am3LC39VW0=";
        
        private EventProcessorClient Processor { get; set; }


        public void Init(BlobContainerClient blobContainerClient)
        {
            var eventHubName = "casa-service-events";
            var consumerGroup = "casa-event-processor";
            EventProcessorClient processor = new EventProcessorClient(blobContainerClient, consumerGroup, eventhubNamespaceConnectionString, eventHubName);
            processor.ProcessEventAsync += ProcessEventHandler;
            processor.ProcessErrorAsync += ProcessErrorHandler;
            Processor = processor;
        }

        public async Task StartProcessorAsync()
        {
            await Processor.StartProcessingAsync();
        }

        public async Task StopProcessorAsync()
        {
            await Processor.StopProcessingAsync();
        }
        static async Task ProcessEventHandler(ProcessEventArgs eventArgs)
        {
            var partition = eventArgs.Data.PartitionKey;
            var sequenceNumber = eventArgs.Data.SequenceNumber;
            // Write the body of the event to the console window
            var str = string.Format("\tReceived event: {0}", Encoding.UTF8.GetString(eventArgs.Data.Body.ToArray()));

            // Update checkpoint in the blob storage so that the app receives only new events the next time it's run
            await eventArgs.UpdateCheckpointAsync();
        }

        static Task ProcessErrorHandler(Azure.Messaging.EventHubs.Processor.ProcessErrorEventArgs eventArgs)
        {
            // Write details about the error to the console window
            Console.WriteLine($"\tPartition '{ eventArgs.PartitionId}': an unhandled exception was encountered. This was not expected to happen.");
            Console.WriteLine(eventArgs.Exception.Message);
            return Task.CompletedTask;
        }

    }

}
