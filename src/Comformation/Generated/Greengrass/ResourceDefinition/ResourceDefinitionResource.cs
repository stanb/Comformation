using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.ResourceDefinition
{
    /// <summary>
    /// AWS::Greengrass::ResourceDefinition
    /// The AWS::Greengrass::ResourceDefinition resource represents a resource definition for AWS IoT Greengrass.
    /// Resource definitions are used to organize your resource definition versions.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-resourcedefinition.html
    /// </summary>
    public class ResourceDefinitionResource : ResourceBase
    {
        public class ResourceDefinitionProperties
        {
            /// <summary>
            /// InitialVersion
            /// The resource definition version to include when the resource definition is created. A resource
            /// definition version contains a list of resource instance property types.
            /// 				
            /// Note To associate a resource definition version after the resource definition is created, 				
            /// create an AWS::Greengrass::ResourceDefinitionVersion 				 resource and specify the ID of this
            /// resource definition.
            /// Required: No
            /// Type: ResourceDefinitionVersion
            /// Update requires: Replacement
            /// </summary>
			public ResourceDefinitionVersion InitialVersion { get; set; }

            /// <summary>
            /// Name
            /// The name of the resource definition.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::Greengrass::ResourceDefinition";

        public ResourceDefinitionProperties Properties { get; } = new ResourceDefinitionProperties();

    }

	public static class ResourceDefinitionAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LatestVersionArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("LatestVersionArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
	}
}
