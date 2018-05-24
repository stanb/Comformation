using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Comformation.CodeBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Generate(args[0]).GetAwaiter().GetResult();
        }

        static async Task Generate(string basePath)
        {
            var url = "https://d3teyb21fexa9r.cloudfront.net/latest/gzip/CloudFormationResourceSpecification.json";

            var schemaBuilder = new SchemaLoader();
            var schema = await schemaBuilder.Load(url);
            var schemaParser = new SchemaParser();
            var codeUnits = schemaParser.Parse(schema);

            var x = Assembly.GetExecutingAssembly().GetName().CodeBase;

            foreach (var clazz in codeUnits.OfType<PropertyTypeClass>())
            {
                var template = new PropertyTypeTemplate(clazz);
                var classContent = template.TransformText();
                var path = Path.Combine(basePath, "Generated", clazz.Path);
                var dir = Path.GetDirectoryName(path);
                Directory.CreateDirectory(dir);
                File.WriteAllText(path, classContent);
            }

            foreach (var clazz in codeUnits.OfType<ResourceClass>())
            {
                var template = new ResourceTypeTemplate(clazz);
                var classContent = template.TransformText();
                var path = Path.Combine(basePath, "Generated", clazz.Path);
                var dir = Path.GetDirectoryName(path);
                Directory.CreateDirectory(dir);
                File.WriteAllText(path, classContent);
            }

        }
    }

    partial class PropertyTypeTemplate
    {
        public PropertyTypeTemplate(PropertyTypeClass propertyType)
        {
            _propertyTypeField = propertyType;
        }
    }

    partial class ResourceTypeTemplate
    {
        public ResourceTypeTemplate(ResourceClass resource)
        {
            _resourceField = resource;
        }
    }
}
