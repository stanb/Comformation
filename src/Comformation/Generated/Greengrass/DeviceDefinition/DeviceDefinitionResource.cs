using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.DeviceDefinition
{
    /// <summary>
    /// AWS::Greengrass::DeviceDefinition
    /// The AWS::Greengrass::DeviceDefinition resource represents a device definition for AWS IoT Greengrass.
    /// 			Device definitions are used to organize your device definition versions.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-devicedefinition.html
    /// </summary>
    public class DeviceDefinitionResource : ResourceBase
    {
        public class DeviceDefinitionProperties
        {
            /// <summary>
            /// InitialVersion
            /// The device definition version to include when the device definition is created. A device definition
            /// version contains a list of device property types.
            /// 				
            /// Note To associate a device definition version after the device definition is created, 				 create an
            /// AWS::Greengrass::DeviceDefinitionVersion 				 resource and specify the ID of this device definition.
            /// Required: No
            /// Type: DeviceDefinitionVersion
            /// Update requires: Replacement
            /// </summary>
			public DeviceDefinitionVersion InitialVersion { get; set; }

            /// <summary>
            /// Name
            /// The name of the device definition.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::Greengrass::DeviceDefinition";

        public DeviceDefinitionProperties Properties { get; } = new DeviceDefinitionProperties();

    }

	public static class DeviceDefinitionAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LatestVersionArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("LatestVersionArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
	}
}
