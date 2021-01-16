using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Registry
{
    /// <summary>
    /// AWS::Glue::Registry
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-registry.html
    /// </summary>
    public class RegistryResource : ResourceBase
    {
        public class RegistryProperties
        {
            /// <summary>
            /// Name
            /// 	
            /// The name of the registry.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Description
            /// 	
            /// A description of the registry.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Tags
            /// 	
            /// AWS tags that contain a key value pair and may be searched by console, command line, or API.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Glue::Registry";

        public RegistryProperties Properties { get; } = new RegistryProperties();

    }

    public static class RegistryAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
