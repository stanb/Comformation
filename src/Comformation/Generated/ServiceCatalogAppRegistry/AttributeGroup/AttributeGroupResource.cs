using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalogAppRegistry.AttributeGroup
{
    /// <summary>
    /// AWS::ServiceCatalogAppRegistry::AttributeGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalogappregistry-attributegroup.html
    /// </summary>
    public class AttributeGroupResource : ResourceBase
    {
        public class AttributeGroupProperties
        {
            /// <summary>
            /// Name
            /// The name of the attribute group.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: \w+
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Description
            /// The description of the attribute group that the user provides.
            /// Required: No
            /// Type: String
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Attributes
            /// A JSON string in the form of nested key-value pairs that represent the attributes in the group and
            /// describes an application and its components.
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Attributes { get; set; }

            /// <summary>
            /// Tags
            /// Key-value pairs you can use to associate with the attribute group.
            /// Required: No
            /// Type: Map of String
            /// Update requires: No interruption
            /// </summary>
            public Dictionary<string, Union<string, IntrinsicFunction>> Tags { get; set; }

        }

        public string Type { get; } = "AWS::ServiceCatalogAppRegistry::AttributeGroup";

        public AttributeGroupProperties Properties { get; } = new AttributeGroupProperties();

    }

    public static class AttributeGroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
