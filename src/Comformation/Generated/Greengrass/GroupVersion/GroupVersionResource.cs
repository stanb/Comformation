using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.GroupVersion
{
    /// <summary>
    /// AWS::Greengrass::GroupVersion
    /// The AWS::Greengrass::GroupVersion resource represents a group version in AWS IoT Greengrass. A group version
    /// references a core definition version, device definition version, subscription definition version, and other
    /// version types that contain the components you want to deploy to a Greengrass core device. The group version
    /// must reference a core definition version that contains one core. Other version types are optionally included,
    /// depending on your business need.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-groupversion.html
    /// </summary>
    public class GroupVersionResource : ResourceBase
    {
        public class GroupVersionProperties
        {
            /// <summary>
            /// LoggerDefinitionVersionArn
            /// The Amazon Resource Name (ARN) of the logger definition version that contains the loggers you want
            /// to deploy with the group version.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> LoggerDefinitionVersionArn { get; set; }

            /// <summary>
            /// DeviceDefinitionVersionArn
            /// The ARN of the device definition version that contains the devices you want to deploy with the group
            /// version.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DeviceDefinitionVersionArn { get; set; }

            /// <summary>
            /// FunctionDefinitionVersionArn
            /// The ARN of the function definition version that contains the functions you want to deploy with the
            /// group version.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> FunctionDefinitionVersionArn { get; set; }

            /// <summary>
            /// CoreDefinitionVersionArn
            /// The ARN of the core definition version that contains the core you want to deploy with the group
            /// version. 				 Currently, the core definition version can contain only one core.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CoreDefinitionVersionArn { get; set; }

            /// <summary>
            /// ResourceDefinitionVersionArn
            /// The ARN of the resource definition version that contains the resources you want to deploy with the
            /// group version.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ResourceDefinitionVersionArn { get; set; }

            /// <summary>
            /// ConnectorDefinitionVersionArn
            /// The ARN of the connector definition version that contains the connectors you want to deploy with the
            /// group version.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ConnectorDefinitionVersionArn { get; set; }

            /// <summary>
            /// SubscriptionDefinitionVersionArn
            /// The ARN of the subscription definition version that contains the subscriptions you want to deploy
            /// with the group version.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SubscriptionDefinitionVersionArn { get; set; }

            /// <summary>
            /// GroupId
            /// The ID of the group associated with this version. This value is a GUID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> GroupId { get; set; }

        }

        public string Type { get; } = "AWS::Greengrass::GroupVersion";

        public GroupVersionProperties Properties { get; } = new GroupVersionProperties();

    }
}
