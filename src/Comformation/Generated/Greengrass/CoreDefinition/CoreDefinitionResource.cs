using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.CoreDefinition
{
    /// <summary>
    /// AWS::Greengrass::CoreDefinition
    /// The AWS::Greengrass::CoreDefinition resource represents a core definition for AWS IoT Greengrass. Core
    /// definitions are used to organize your core definition versions.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-coredefinition.html
    /// </summary>
    public class CoreDefinitionResource : ResourceBase
    {
        public class CoreDefinitionProperties
        {
            /// <summary>
            /// InitialVersion
            /// The core definition version to include when the core definition is created. Currently, a core
            /// definition version can contain only one core.
            /// 				
            /// Note To associate a core definition version after the core definition is created, 				 create an
            /// AWS::Greengrass::CoreDefinitionVersion 				 resource and specify the ID of this core definition.
            /// Required: No
            /// Type: CoreDefinitionVersion
            /// Update requires: Replacement
            /// </summary>
			public CoreDefinitionVersion InitialVersion { get; set; }

            /// <summary>
            /// Name
            /// The name of the core definition.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::Greengrass::CoreDefinition";

        public CoreDefinitionProperties Properties { get; } = new CoreDefinitionProperties();

    }

	public static class CoreDefinitionAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LatestVersionArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("LatestVersionArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
	}
}
