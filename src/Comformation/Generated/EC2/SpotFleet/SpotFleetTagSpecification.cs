using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// AWS::EC2::SpotFleet SpotFleetTagSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleettagspecification.html
    /// </summary>
    public class SpotFleetTagSpecification
    {

        /// <summary>
        /// ResourceType
        /// The type of resource. Currently, the only resource type that is supported is instance. To tag the
        /// Spot Fleet request on creation, use the TagSpecifications parameter in SpotFleetRequestConfigData .
        /// Required: No
        /// Type: String
        /// Allowed values: client-vpn-endpoint | customer-gateway | dedicated-host | dhcp-options |
        /// egress-only-internet-gateway | elastic-gpu | elastic-ip | export-image-task | export-instance-task |
        /// fleet | fpga-image | host-reservation | image | import-image-task | import-snapshot-task | instance
        /// | instance-event-window | internet-gateway | key-pair | launch-template |
        /// local-gateway-route-table-vpc-association | natgateway | network-acl | network-insights-analysis |
        /// network-insights-path | network-interface | placement-group | reserved-instances | route-table |
        /// security-group | security-group-rule | snapshot | spot-fleet-request | spot-instances-request |
        /// subnet | traffic-mirror-filter | traffic-mirror-session | traffic-mirror-target | transit-gateway |
        /// transit-gateway-attachment | transit-gateway-connect-peer | transit-gateway-multicast-domain |
        /// transit-gateway-route-table | volume | vpc | vpc-flow-log | vpc-peering-connection | vpn-connection
        /// | vpn-gateway
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ResourceType")]
        public Union<string, IntrinsicFunction> ResourceType { get; set; }

        /// <summary>
        /// Tags
        /// The tags.
        /// Required: No
        /// Type: List of Tag
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Tags")]
        public List<Tag> Tags { get; set; }

    }
}
