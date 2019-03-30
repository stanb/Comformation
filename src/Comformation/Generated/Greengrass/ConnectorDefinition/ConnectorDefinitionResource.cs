using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.ConnectorDefinition
{
    /// <summary>
    /// AWS::Greengrass::ConnectorDefinition
    /// The AWS::Greengrass::ConnectorDefinition resource represents a connector definition for AWS IoT Greengrass.
    /// Connector definitions are used to organize your connector definition versions.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-connectordefinition.html
    /// </summary>
    public class ConnectorDefinitionResource : ResourceBase
    {
        public class ConnectorDefinitionProperties
        {
            /// <summary>
            /// InitialVersion
            /// The connector definition version to include when the connector definition is created. A connector
            /// definition version contains a list of connector property types.
            /// 				
            /// Note To associate a connector definition version after the connector definition is created, 				
            /// create an AWS::Greengrass::ConnectorDefinitionVersion 				 resource and specify the ID of this
            /// connector definition.
            /// Required: No
            /// Type: ConnectorDefinitionVersion
            /// Update requires: Replacement
            /// </summary>
			public ConnectorDefinitionVersion InitialVersion { get; set; }

            /// <summary>
            /// Name
            /// The name of the connector definition.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::Greengrass::ConnectorDefinition";

        public ConnectorDefinitionProperties Properties { get; } = new ConnectorDefinitionProperties();

    }

	public static class ConnectorDefinitionAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LatestVersionArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("LatestVersionArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
	}
}
