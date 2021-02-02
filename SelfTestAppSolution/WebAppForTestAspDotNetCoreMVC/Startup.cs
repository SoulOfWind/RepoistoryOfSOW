using Btc.Swagger;
using Btc.Web.Filters;
using Btc.Web.Utils;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using WebAppForTestAspDotNetCoreMVC.DBContextAndEntities;

namespace WebAppForTestAspDotNetCoreMVC
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
            //services.AddControllersWithViews();
            //services.AddBtcWeb(Configuration);
            //services.AddBtcInfoEndpoint(Configuration);
            //services.AddHsts(options => { options.Preload = true; });
            //services.AddBtcSwagger1(typeof(Startup).GetTypeInfo().Assembly);
            //services.AddResponseCompression(options => options.Providers.Add<GzipCompressionProvider>());
            //services.Configure<GzipCompressionProviderOptions>(options => options.Level = CompressionLevel.Fastest);
            //services.AddRouting(options => options.LowercaseUrls = true);
            //services.AddHttpsRedirection(options =>
            //{
            //    options.RedirectStatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status307TemporaryRedirect;
            //});
            //services.AddMvc();
            //var iMVCBuilder=services.AddControllers(o => { o.Filters.Add(typeof(LogRouteTemplateFilter)); });
            //iMVCBuilder.SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            //services.AddHealthChecks();
            //services.AddDbContext<CDPreActivationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Test_DB")));


            services.AddBtcWeb(Configuration);
            services.AddBtcInfoEndpoint(Configuration);
            services.AddResponseCompression(options => options.Providers.Add<GzipCompressionProvider>());
            services.Configure<GzipCompressionProviderOptions>(options => options.Level = CompressionLevel.Fastest);
            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddHsts(options => { options.Preload = true; });

            services.AddHttpsRedirection(options =>
            {
                options.RedirectStatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status307TemporaryRedirect;
            });

            services.AddMvc();
            services.AddBtcSwagger(typeof(Startup).GetTypeInfo().Assembly);
            services.AddHealthChecks();





        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider provider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseBtcWeb();
            app.UseRouting();
            app.UseResponseCompression();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBtcHealth();
                endpoints.MapBtcInfo();
                endpoints.MapBtcHealthUpstreams();
            });


            //app.UseMvc();
            app.UseBtcSwagger(provider);


            //app.UseBtcSwagger(provider);





        }
    }
}
