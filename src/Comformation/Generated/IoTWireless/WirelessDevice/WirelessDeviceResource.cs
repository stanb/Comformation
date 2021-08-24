using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.WirelessDevice
{
    /// <summary>
    /// AWS::IoTWireless::WirelessDevice
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-wirelessdevice.html
    /// </summary>
    public class WirelessDeviceResource : ResourceBase
    {
        public class WirelessDeviceProperties
        {
            /// <summary>
            /// Type
            /// 		
            /// The wireless device type. Must be Sidewalk or LoRaWAN.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// Name
            /// The name of the new resource. Maximum length is 256.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Description
            /// 		
            /// The description of the new resource. Maximum length is 2048.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// DestinationName
            /// 		
            /// The name of the destination to assign to the new wireless device. Can have only have alphanumeric, -
            /// (hyphen) and _ (underscore) characters and it 			can&#39;t have any spaces.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DestinationName { get; set; }

            /// <summary>
            /// LoRaWAN
            /// 		
            /// The device configuration information to use to create the wireless device. Must be at least one of
            /// OtaaV10x, OtaaV11, AbpV11, or AbpV10x.
            /// Required: No
            /// Type: LoRaWANDevice
            /// Update requires: No interruption
            /// </summary>
            public LoRaWANDevice LoRaWAN { get; set; }

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

            /// <summary>
            /// ThingArn
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ThingArn { get; set; }

            /// <summary>
            /// LastUplinkReceivedAt
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> LastUplinkReceivedAt { get; set; }

        }

        public string Type { get; } = "AWS::IoTWireless::WirelessDevice";

        public WirelessDeviceProperties Properties { get; } = new WirelessDeviceProperties();

    }

    public static class WirelessDeviceAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ThingName = new ResourceAttribute<Union<string, IntrinsicFunction>>("ThingName");
    }
}
