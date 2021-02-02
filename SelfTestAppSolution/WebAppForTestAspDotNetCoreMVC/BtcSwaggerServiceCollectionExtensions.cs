using Btc.Swagger;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace WebAppForTestAspDotNetCoreMVC
{
    public static class BtcSwaggerServiceCollectionExtensions
    {
        public static IServiceCollection AddBtcSwagger1(this IServiceCollection services, Assembly assembly, bool includeControllerXmlComments = false)
        {
            services.AddApiVersioning(delegate (ApiVersioningOptions options)
            {
                options.ReportApiVersions = true;
            });
            services.AddVersionedApiExplorer(delegate (ApiExplorerOptions options)
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            });
            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
            List<string> xmlFiles = GetXmlFiles(assembly);
            services.AddSwaggerGen(delegate (SwaggerGenOptions options)
            {
                options.SchemaFilter<EnumSchemaFilter>(Array.Empty<object>());
                foreach (string item in xmlFiles)
                {
                    options.IncludeXmlComments(item, includeControllerXmlComments);
                }

                options.DocumentFilter<VersionedApiDocumentFilter>(Array.Empty<object>());
            });
            return services;
        }

        private static List<string> GetXmlFiles(Assembly assembly)
        {
            List<string> list = new List<string>();
            string xmlFileNameForAssembly = GetXmlFileNameForAssembly(assembly);
            if (xmlFileNameForAssembly != null)
            {
                list.Add(xmlFileNameForAssembly);
            }

            AssemblyName[] referencedAssemblies = assembly.GetReferencedAssemblies();
            for (int i = 0; i < referencedAssemblies.Length; i++)
            {
                string xmlFileNameForAssembly2 = GetXmlFileNameForAssembly(Assembly.Load(referencedAssemblies[i]));
                if (xmlFileNameForAssembly2 != null)
                {
                    list.Add(xmlFileNameForAssembly2);
                }
            }

            return list;
        }

        private static string GetXmlFileNameForAssembly(Assembly assembly)
        {
            if (!Uri.TryCreate(assembly.CodeBase, UriKind.Absolute, out Uri result))
            {
                return null;
            }

            string text = Path.ChangeExtension(result.LocalPath, ".xml");
            if (!File.Exists(text))
            {
                return null;
            }

            return text;
        }
    }
}
