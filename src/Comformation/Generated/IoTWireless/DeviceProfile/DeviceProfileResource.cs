using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.DeviceProfile
{
    /// <summary>
    /// AWS::IoTWireless::DeviceProfile
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-deviceprofile.html
    /// </summary>
    public class DeviceProfileResource : ResourceBase
    {
        public class DeviceProfileProperties
        {
            /// <summary>
            /// Name
            /// 		
            /// The name of the new resource. Maximum length is 256 characters.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// LoRaWAN
            /// LoRaWANDeviceProfile object.
            /// Required: No
            /// Type: LoRaWANDeviceProfile
            /// Update requires: No interruption
            /// </summary>
            public LoRaWANDeviceProfile LoRaWAN { get; set; }

            /// <summary>
            /// Tags
            /// 		 		
            /// An array of key-value pairs to apply to this resource. Tags can have a minimum of 0 and a maximum of
            /// 50 items.
            /// 		
            /// For more information, see Tag.
            /// 	
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IoTWireless::DeviceProfile";

        public DeviceProfileProperties Properties { get; } = new DeviceProfileProperties();

    }

    public static class DeviceProfileAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
    }
}
