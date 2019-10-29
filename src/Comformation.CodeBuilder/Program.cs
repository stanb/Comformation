using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DotLiquid;

namespace Comformation.CodeBuilder
{
    class Program
    {
        static async Task Main(string[] args)
        { 
            NLog.LogManager.LoadConfiguration("nlog.config");
            var logger = NLog.LogManager.GetCurrentClassLogger();
            var missingDocumentationLogger = NLog.LogManager.GetLogger("MissingDocumentation");
            try
            {
                var basePath = args[0];
                var url = "https://d1uauaxba7bl26.cloudfront.net/latest/gzip/CloudFormationResourceSpecification.json";

                var schemaBuilder = new SchemaLoader();
                var schema = await schemaBuilder.Load(url);
                var schemaParser = new SchemaParser(schema);
                (var propertyTypes, var resources) = schemaParser.Parse();

                var propertyTypeTemplate = await ReadTemplate("Comformation.CodeBuilder.PropertyTypeTemplate.liquid");
                var resourceTypeTemplate = await ReadTemplate("Comformation.CodeBuilder.ResourceTypeTemplate.liquid");

                var counter = 1;
                logger.Trace("Generating Property Types...");
                foreach (var clazz in propertyTypes)
                {
                    logger.Trace($"{counter++:000}: {clazz.Namespace}.{clazz.Name}");
                    
                    var docParser = await DocumentationParser.Parse(clazz.Documentation);
                    string[] classDesc = null;
                    if (docParser == null)
                    {
                        missingDocumentationLogger.Warn($"{clazz.Namespace}.{clazz.Name}, {clazz.Documentation}, ");
                        classDesc = new[] { $"Missing documentation {clazz.Documentation}" };
                    }
                    else
                    {
                        classDesc = docParser.GetResourceDocumentation();
                        if (classDesc == null)
                        {
                        }
                    }

                    var classContent = propertyTypeTemplate.Render(Hash.FromAnonymousObject(
                        new
                        {
                            propertyType = new
                            {
                                clazz.Name,
                                clazz.Namespace,
                                Documentation = classDesc,
                                clazz.Path,
                                Properties = clazz.Properties.Select(prop =>
                                {
                                    var propDoc = docParser != null ? docParser.GetPropertyDocumentation(prop.Name) : new[] { prop.Name };
                                    var x = new
                                    {
                                        prop.Name,
                                        prop.Type,
                                        Documentation = propDoc,
                                        prop.JsonProperty
                                    };
                                    return x;
                                }).ToArray()
                            }
                        }));
                    var path = Path.Combine(basePath, "Generated", clazz.Path);
                    var dir = Path.GetDirectoryName(path);
                    Directory.CreateDirectory(dir);
                    File.WriteAllText(path, classContent);
                }

                logger.Trace("Generating Resources Types...");
                foreach (var clazz in resources)
                {
                    logger.Trace($"{counter++:000}: {clazz.Namespace}.{clazz.Name}Resource");

                    var docParser = await DocumentationParser.Parse(clazz.Documentation);
                    string[] classDesc = null;
                    if (docParser == null)
                    {
                        missingDocumentationLogger.Warn($"{clazz.Namespace}.{clazz.Name}, {clazz.Documentation}, ");
                        classDesc = new[] { $"Missing documentation {clazz.Documentation}" };
                    }
                    else
                    {
                        classDesc = docParser.GetResourceDocumentation();
                        if (classDesc == null)
                        {
                        }
                    }

                    var classContent = resourceTypeTemplate.Render(Hash.FromAnonymousObject(
                        new
                        {
                            resource = new
                            {
                                clazz.Name,
                                clazz.Namespace,
                                Documentation = classDesc,
                                clazz.Path,
                                clazz.Type,
                                clazz.HasCreationPolicy,
                                clazz.HasUpdatePolicy,
                                Properties = clazz.Properties.Select(prop =>
                                {
                                    var propDoc = docParser != null ? docParser.GetPropertyDocumentation(prop.Name) : new[] { prop.Name };
                                    var x = new
                                    {
                                        Name = prop.Name.Equals($"{clazz.Name}Properties") ? $"{prop.Name}_" : prop.Name,
                                        Type = prop.Type.Equals($"{clazz.Name}Properties") ? $"{clazz.Namespace}.{prop.Type}" : prop.Type,
                                        Documentation = propDoc,
                                        prop.JsonProperty
                                    };
                                    return x;
                                }).ToArray(),
                                Attributes = clazz.Attributes.Select(attr => new
                                {
                                    attr.Name,
                                    attr.Type,
                                    Value = string.Join("\", \"", attr.Value.Split('.'))
                                }).ToArray()
                            }
                        }));
                    var path = Path.Combine(basePath, "Generated", clazz.Path);
                    var dir = Path.GetDirectoryName(path);
                    Directory.CreateDirectory(dir);
                    File.WriteAllText(path, classContent);
                }
            }
            finally
            {
                NLog.LogManager.Shutdown();
            }
        }

        private static async Task<Template> ReadTemplate(string resourceName)
        {
            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                var str = await reader.ReadToEndAsync();
                return Template.Parse(str);
            }
        }
    }
}
