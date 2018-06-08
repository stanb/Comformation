using System;
using System.Collections.Generic;
using System.Text;

namespace Comformation.CodeBuilder
{
    public class Schema
    {
        public string ResourceSpecificationVersion { get; set; }
        public IDictionary<string, PropertySpec> PropertyTypes { get; set; }
        public IDictionary<string, ResourceSpec> ResourceTypes { get; set; }
    }

    public class ResourceSpec
    {
        public string Documentation { get; set; }
        public IDictionary<string, Attribute> Attributes { get; set; }
        public IDictionary<string, Property> Properties { get; set; }
    }

    public class PropertySpec
    {
        public string Documentation { get; set; }
        public IDictionary<string, Property> Properties { get; set; }
    }

    public enum PrimitiveType
    {
        String,
        Long,
        Integer,
        Double,
        Boolean,
        Timestamp,
        Json
    }

    public enum UpdateType
    {
        Mutable,
        Immutable,
        Conditional
    }

    public enum PropertyType
    {
        List,
        Map
    }

    public class Property : PropertyBase
    {
        public bool Required { get; set; }
        public bool DuplicatesAllowed { get; set; }
        public string Documentation { get; set; }
        public UpdateType UpdateType { get; set; }
    }

    public class Attribute : PropertyBase
    {
    }

    public abstract class PropertyBase
    {
        public string ItemType { get; set; }
        public PrimitiveType? PrimitiveItemType { get; set; }
        public PrimitiveType? PrimitiveType { get; set; }
        public string Type { get; set; }
    }

    public class AttributeMember
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
    }

    public class PropertyMember
    {
        public string JsonProperty { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class PropertyTypeClass : CodeUnit
    {
        public string Documentation { get; set; }
        public IEnumerable<PropertyMember> Properties { get; set; }
    }

    public class ResourceClass : CodeUnit
    {
        public string Type { get; set; }
        public string Documentation { get; set; }
        public IEnumerable<PropertyMember> Properties { get; set; }
        public IEnumerable<AttributeMember> Attributes { get; set; }
    }

    public abstract class CodeUnit
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public string Namespace { get; set; }
    }
}
