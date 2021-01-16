using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.ResourceDefinitionVersion
{
    /// <summary>
    /// AWS::Greengrass::ResourceDefinitionVersion
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-resourcedefinitionversion.html
    /// </summary>
    public class ResourceDefinitionVersionResource : ResourceBase
    {
        public class ResourceDefinitionVersionProperties
        {
            /// <summary>
            /// Resources
            /// The resources in this version.
            /// Required: Yes
            /// Type: List of ResourceInstance
            /// Update requires: Replacement
            /// </summary>
            public List<ResourceInstance> Resources { get; set; }

            /// <summary>
            /// ResourceDefinitionId
            /// The ID of the resource definition associated with this version. This value is a GUID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ResourceDefinitionId { get; set; }

        }

        public string Type { get; } = "AWS::Greengrass::ResourceDefinitionVersion";

        public ResourceDefinitionVersionProperties Properties { get; } = new ResourceDefinitionVersionProperties();

    }
}
