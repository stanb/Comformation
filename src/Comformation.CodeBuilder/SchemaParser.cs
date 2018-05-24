using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Comformation.CodeBuilder
{
    public class SchemaParser
    {
        private const string BaseNamespace = "Comformation";

        public IEnumerable<CodeUnit> Parse(Schema schema)
        {
            return Parse(schema.PropertyTypes)
                .AsEnumerable<CodeUnit>().
                Concat(Parse(schema.ResourceTypes).AsEnumerable<CodeUnit>());
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
            }).ToList();

            return propertyClasses;
        }

        private IEnumerable<ResourceClass> Parse(IDictionary<string, ResourceSpec> resourceSpecs)
        {
            var resourceClasses = resourceSpecs.Select(x =>
            {
                var nameParts = x.Key.Split(new[] { "::" }, StringSplitOptions.RemoveEmptyEntries).Skip(1);
                var className = nameParts.Last();
                var namespaceName = string.Join(".", nameParts.Prepend(BaseNamespace));
                var path = Path.ChangeExtension(Path.Combine(Path.Combine(nameParts.ToArray()), className + "Resource"), ".cs");

                var resourceClass = new ResourceClass
                {
                    Type = x.Key,
                    Name = className,
                    Namespace = namespaceName,
                    Path = path,
                    Documentation = x.Value.Documentation,
                    Attributes = Parse(x.Value.Attributes),
                    Properties = Parse(x.Value.Properties)
                };
                return resourceClass;
            }).ToList();
            return resourceClasses;
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
                    Documentation = property.Value.Documentation,
                    Type = ParsePropertyType(property.Value, property.Value.Required)
                }).ToList();
            return members;
        }

        private string ParsePropertyType(PropertyBase property, bool required)
        {
            string type;
            if (property.PrimitiveType.HasValue)
            {
                type = Parse(property.PrimitiveType.Value, required);
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
            switch (primitiveType)
            {
                case PrimitiveType.Boolean:
                    return required ? "bool" : "bool?";
                case PrimitiveType.Double:
                    return required ? "double" : "double?";
                case PrimitiveType.Integer:
                    return required ? "int" : "int?";
                case PrimitiveType.Long:
                    return required ? "long" : "long?";
                case PrimitiveType.String:
                    return "string";
                case PrimitiveType.Json:
                    return "Newtonsoft.Json.Linq.JToken";
                case PrimitiveType.Timestamp:
                    return "string";
                default:
                    throw new Exception();
            }
        }
    }
}
