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
            /// The name of the new resource.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Description
            /// The description of the new resource.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Tags
            /// 		 		
            /// An array of key-value pairs to apply to this resource.
            /// 		
            /// For more information, see Tag.
            /// 	
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// LoRaWANGateway
            /// The gateway configuration information to use to create the wireless gateway.
            /// Required: Yes
            /// Type: LoRaWANGateway
            /// Update requires: No interruption
            /// </summary>
            public LoRaWANGateway LoRaWANGateway { get; set; }

            /// <summary>
            /// NextToken
            /// 		
            /// This parameter isn&#39;t needed to create this resource. Do not include it in your template.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> NextToken { get; set; }

            /// <summary>
            /// ThingName
            /// The name of the thing associated with the wireless gateway. The value is empty if a thing isn&#39;t
            /// associated with the gateway.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ThingName { get; set; }

        }

        public string Type { get; } = "AWS::IoTWireless::WirelessGateway";

        public WirelessGatewayProperties Properties { get; } = new WirelessGatewayProperties();

    }

    public static class WirelessGatewayAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ThingArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ThingArn");
    }
}
