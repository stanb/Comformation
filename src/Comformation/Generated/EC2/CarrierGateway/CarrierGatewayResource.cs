using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.CarrierGateway
{
    /// <summary>
    /// AWS::EC2::CarrierGateway
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-carriergateway.html
    /// </summary>
    public class CarrierGatewayResource : ResourceBase
    {
        public class CarrierGatewayProperties
        {
            /// <summary>
            /// VpcId
            /// The ID of the VPC associated with the carrier gateway.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> VpcId { get; set; }

            /// <summary>
            /// Tags
            /// The tags assigned to the carrier gateway.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EC2::CarrierGateway";

        public CarrierGatewayProperties Properties { get; } = new CarrierGatewayProperties();

    }

    public static class CarrierGatewayAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CarrierGatewayId = new ResourceAttribute<Union<string, IntrinsicFunction>>("CarrierGatewayId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> State = new ResourceAttribute<Union<string, IntrinsicFunction>>("State");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> OwnerId = new ResourceAttribute<Union<string, IntrinsicFunction>>("OwnerId");
    }
}
