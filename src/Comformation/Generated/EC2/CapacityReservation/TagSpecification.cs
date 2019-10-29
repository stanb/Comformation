using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.CapacityReservation
{
    /// <summary>
    /// AWS::EC2::CapacityReservation TagSpecification
    /// An array of key-value pairs to apply to this resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-capacityreservation-tagspecification.html
    /// </summary>
    public class TagSpecification
    {

        /// <summary>
        /// ResourceType
        /// The type of resource to tag. Specify capacity-reservation.
        /// Required: No
        /// Type: String
        /// Allowed Values: client-vpn-endpoint | customer-gateway | dedicated-host | dhcp-options | elastic-ip
        /// | fleet | fpga-image | host-reservation | image | instance | internet-gateway | launch-template |
        /// natgateway | network-acl | network-interface | reserved-instances | route-table | security-group |
        /// snapshot | spot-instances-request | subnet | traffic-mirror-filter | traffic-mirror-session |
        /// traffic-mirror-target | transit-gateway | transit-gateway-attachment | transit-gateway-route-table |
        /// volume | vpc | vpc-peering-connection | vpn-connection | vpn-gateway
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceType")]
        public Union<string, IntrinsicFunction> ResourceType { get; set; }

        /// <summary>
        /// Tags
        /// The tags to apply to the resource.
        /// Required: No
        /// Type: List of Tag
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Tags")]
        public List<Tag> Tags { get; set; }

    }
}
