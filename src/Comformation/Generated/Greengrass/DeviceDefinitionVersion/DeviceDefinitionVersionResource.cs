using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.DeviceDefinitionVersion
{
    /// <summary>
    /// AWS::Greengrass::DeviceDefinitionVersion
    /// The AWS::Greengrass::DeviceDefinitionVersion resource represents a device definition version for AWS IoT
    /// Greengrass. A device definition version contains a list of devices.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-devicedefinitionversion.html
    /// </summary>
    public class DeviceDefinitionVersionResource : ResourceBase
    {
        public class DeviceDefinitionVersionProperties
        {
            /// <summary>
            /// DeviceDefinitionId
            /// The ID of the device definition associated with this version. This value is a GUID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DeviceDefinitionId { get; set; }

            /// <summary>
            /// Devices
            /// The devices in this version.
            /// Required: Yes
            /// Type: List of Device
            /// Update requires: Replacement
            /// </summary>
			public List<Device> Devices { get; set; }

        }

        public string Type { get; } = "AWS::Greengrass::DeviceDefinitionVersion";

        public DeviceDefinitionVersionProperties Properties { get; } = new DeviceDefinitionVersionProperties();

    }
}
