using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Comformation.CodeBuilder
{
    public class SchemaParser
    {
        private const string BaseNamespace = "Comformation";

        public (IEnumerable<PropertyTypeClass>, IEnumerable<ResourceClass>) Parse(Schema schema)
        {
            var propertyTypes = Parse(schema.PropertyTypes);
            var resources = Parse(schema.ResourceTypes);
            return (propertyTypes, resources);
        }

        private IEnumerable<PropertyTypeClass> Parse(IDictionary<string, PropertySpec> propertySpecs)
        {
            var propertyClasses = propertySpecs.Select(x =>
            {
                var keyParts = x.Key.Split('.').Reverse().ToArray();
                var className = keyParts[0];
                string path;
                string namespaceName;

                if (keyParts.Length == 1)
                {
                    namespaceName = string.Join(".", BaseNamespace);
                    path = className;
                }
                else
                {
                    var nameParts = keyParts[1].Split(new string[] {"::"}, StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();
                    namespaceName = string.Join(".", nameParts.Prepend(BaseNamespace));
                    var pathParts = nameParts.Append(className).ToArray();
                    path = Path.Combine(pathParts);
                }
                path = Path.ChangeExtension(path, ".cs");

                var propertyClass = new PropertyTypeClass
                {
                    Name = className,
                    Namespace = namespaceName,
                    Path = path,
                    Documentation = x.Value.Documentation,
                    Properties = Parse(x.Value.Properties)
                };
                FixPropertyNames(propertyClass);

                return propertyClass;
            })
            .OrderBy(x => $"{x.Namespace}.{x.Name}")
            .ToList();

            return propertyClasses;
        }

        private IEnumerable<ResourceClass> Parse(IDictionary<string, ResourceSpec> resourceSpecs)
        {
            var resourceClasses = resourceSpecs.Select(x => Parse(x.Key, x.Value))
                .OrderBy(x => x.Namespace)
                .ToList();
            return resourceClasses;
        }

        private ResourceClass Parse(string type, ResourceSpec resourceSpec)
        {
            var nameParts = type.Split(new[] { "::" }, StringSplitOptions.RemoveEmptyEntries).Skip(1);
            var className = nameParts.Last();
            var namespaceName = string.Join(".", nameParts.Prepend(BaseNamespace));
            var path = Path.ChangeExtension(Path.Combine(Path.Combine(nameParts.ToArray()), className + "Resource"), ".cs");

            var resourceClass = new ResourceClass
            {
                Type = type,
                Name = className,
                Namespace = namespaceName,
                Path = path,
                Documentation = resourceSpec.Documentation,
                Attributes = Parse(resourceSpec.Attributes),
                Properties = Parse(resourceSpec.Properties)
            };
            return resourceClass;
        }

        private void FixPropertyNames(PropertyTypeClass propertyClass)
        {
            foreach (var prop in propertyClass.Properties)
            {
                if (prop.Name.Equals(propertyClass.Name))
                    prop.Name += "_";
            }
        }

        private IEnumerable<AttributeMember> Parse(IDictionary<string, Attribute> attributes)
        {
            if (attributes == null)
                return Enumerable.Empty<AttributeMember>();

            var members = attributes.Select(x =>
                new AttributeMember
                {
                    Name = x.Key.Replace(".", "_"),
                    Value = x.Key,
                    Type = ParsePropertyType(x.Value, true)
                }).ToList();
            return members;
        }

        private IEnumerable<PropertyMember> Parse(IDictionary<string, Property> properties)
        {
            var members = properties.Select(property =>
                new PropertyMember
                {
                    JsonProperty = property.Key,
                    Name = property.Key,
                    Type = ParsePropertyType(property.Value, property.Value.Required)
                }).ToList();
            return members;
        }

        private string ParsePropertyType(PropertyBase property, bool required)
        {
            string type;
            if (property.PrimitiveType.HasValue)
            {
                type = Parse(property.PrimitiveType.Value, true);
            }
            else
            {
                string itemType;
                switch (property.Type)
                {
                    case "List":
                        itemType = property.PrimitiveItemType.HasValue ?
                            Parse(property.PrimitiveItemType.Value, true) :
                            property.ItemType;

                        type = $"List<{itemType}>";
                        break;
                    case "Map":
                        itemType = property.PrimitiveItemType.HasValue ?
                            Parse(property.PrimitiveItemType.Value, true) :
                            property.ItemType;

                        type = $"Dictionary<string, {itemType}>";
                        break;
                    default:
                        type = property.Type;
                        break;
                }
            }

            return type;
        }

        private string Parse(PrimitiveType primitiveType, bool required)
        {
            string type;
            switch (primitiveType)
            {
                case PrimitiveType.Boolean:
                    type = required ? "bool" : "bool?";
                    break;
                case PrimitiveType.Double:
                    type = required ? "double" : "double?";
                    break;
                case PrimitiveType.Integer:
                    type = required ? "int" : "int?";
                    break;
                case PrimitiveType.Long:
                    type = required ? "long" : "long?";
                    break;
                case PrimitiveType.String:
                    type = "string";
                    break;
                case PrimitiveType.Json:
                    type = "Newtonsoft.Json.Linq.JToken";
                    break;
                case PrimitiveType.Timestamp:
                    type = "string";
                    break;
                default:
                    throw new Exception();
            }
            return $"Union<{type}, IntrinsicFunction>";
        }
    }
}
