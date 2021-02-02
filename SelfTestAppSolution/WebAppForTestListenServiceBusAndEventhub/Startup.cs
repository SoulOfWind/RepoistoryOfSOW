using Azure.Messaging.ServiceBus;
using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppForTestListenServiceBusAndEventhub.DBContextAndEntities;
using WebAppForTestListenServiceBusAndEventhub.Processors;
using WebAppForTestListenServiceBusAndEventhub.Senders;

namespace WebAppForTestListenServiceBusAndEventhub
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var dbConnectionStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;App=EntityFramework";
            var serviceBusConnStr = "Endpoint=sb://omcnscdpreaceint.servicebus.chinacloudapi.cn/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=auboakOMX5JzsOR526TDJiYbE9n+/vXvzv+PlOwT9mE=";
            var blobStorageConnectionString = "DefaultEndpointsProtocol=https;AccountName=omcsgcdpreaceint;AccountKey=Vb30ol9gD2QXdG/t6iJXtaSYE6B16ycywyPr1VDjFjHd4BZ2IN1fB2pPFpT/JNmNaIZCyBjcxLWbT6XAs1eU+g==;EndpointSuffix=core.chinacloudapi.cn";
            var blobContainerName = "azure-webjob-eventhub";
            var blobContainerClient = new BlobContainerClient(blobStorageConnectionString, blobContainerName);
            var processorOfCASACoreEvent = new ProcessorOfCASACoreEvent();
            processorOfCASACoreEvent.Init(blobContainerClient);
            ServiceBusClient client = new ServiceBusClient(serviceBusConnStr);
            var processorOfSendToCURNRQueue = new ProcessorOfSendToCURNRQueue();
            processorOfSendToCURNRQueue.Init(client);
            var senderOfTestDWHTopic = new SenderOfTestDWHTopic();
            senderOfTestDWHTopic.Init(client);
            

            

            services.AddSingleton(typeof(ProcessorOfCASACoreEvent), processorOfCASACoreEvent);
            services.AddSingleton(typeof(ProcessorOfSendToCURNRQueue), processorOfSendToCURNRQueue);
            services.AddSingleton(typeof(SenderOfTestDWHTopic), senderOfTestDWHTopic);
            services.AddDbContext<CDPreActivationDbContext>(options => options.UseSqlServer(dbConnectionStr));
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAppForTestListenServiceBusAndEventhub", Version = "v1" });
            });



            // Start Processors
            processorOfCASACoreEvent.StartProcessorAsync().ConfigureAwait(false).GetAwaiter().GetResult();
            processorOfSendToCURNRQueue.StartProcessorAsync().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAppForTestListenServiceBusAndEventhub v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });



        }
    }
}
