using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT1Click.Device
{
    /// <summary>
    /// AWS::IoT1Click::Device
    /// The AWS::IoT1Click::Device resource controls the enabled state of an AWS IoT 1-Click compatible device. For
    /// more information, see Device in the AWS IoT 1-Click Devices API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot1click-device.html
    /// </summary>
    public class DeviceResource : ResourceBase
    {
        public class DeviceProperties
        {
            /// <summary>
            /// DeviceId
            /// The ID of the device, such as G030PX0312744DWM.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DeviceId { get; set; }

            /// <summary>
            /// Enabled
            /// A Boolean value indicating whether the device is enabled (true) or not (false).
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> Enabled { get; set; }

        }

        public string Type { get; } = "AWS::IoT1Click::Device";

        public DeviceProperties Properties { get; } = new DeviceProperties();

    }

	public static class DeviceAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DeviceId = new ResourceAttribute<Union<string, IntrinsicFunction>>("DeviceId");
        public static readonly ResourceAttribute<Union<bool, IntrinsicFunction>> Enabled = new ResourceAttribute<Union<bool, IntrinsicFunction>>("Enabled");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
