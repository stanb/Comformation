using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.WirelessGateway
{
    /// <summary>
    /// AWS::IoTWireless::WirelessGateway
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-wirelessgateway.html
    /// </summary>
    public class WirelessGatewayResource : ResourceBase
    {
        public class WirelessGatewayProperties
        {
            /// <summary>
            /// Name
            /// 		
            /// The name of the new resource. The maximum length is 256 characters.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Description
            /// The description of the new resource. The maximum length is 2048 characters.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

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
            /// LoRaWAN
            /// The gateway configuration information to use to create the wireless gateway.
            /// Required: Yes
            /// Type: LoRaWANGateway
            /// Update requires: No interruption
            /// </summary>
            public LoRaWANGateway LoRaWAN { get; set; }

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

        public string Type { get; } = "AWS::IoTWireless::WirelessGateway";

        public WirelessGatewayProperties Properties { get; } = new WirelessGatewayProperties();

    }

    public static class WirelessGatewayAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ThingName = new ResourceAttribute<Union<string, IntrinsicFunction>>("ThingName");
    }
}
