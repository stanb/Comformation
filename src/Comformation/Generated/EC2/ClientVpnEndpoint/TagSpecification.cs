using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.ClientVpnEndpoint
{
    /// <summary>
    /// AWS::EC2::ClientVpnEndpoint TagSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-tagspecification.html
    /// </summary>
    public class TagSpecification
    {

        /// <summary>
        /// ResourceType
        /// 		
        /// The type of resource to tag.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: client-vpn-endpoint | customer-gateway | dedicated-host | dhcp-options |
        /// egress-only-internet-gateway | elastic-gpu | elastic-ip | export-image-task | export-instance-task |
        /// fleet | fpga-image | host-reservation | image | import-image-task | import-snapshot-task | instance
        /// | internet-gateway | key-pair | launch-template | local-gateway-route-table-vpc-association |
        /// natgateway | network-acl | network-interface | placement-group | reserved-instances | route-table |
        /// security-group | snapshot | spot-fleet-request | spot-instances-request | subnet |
        /// traffic-mirror-filter | traffic-mirror-session | traffic-mirror-target | transit-gateway |
        /// transit-gateway-attachment | transit-gateway-multicast-domain | transit-gateway-route-table | volume
        /// | vpc | vpc-flow-log | vpc-peering-connection | vpn-connection | vpn-gateway
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceType")]
        public Union<string, IntrinsicFunction> ResourceType { get; set; }

        /// <summary>
        /// Tags
        /// The tags to apply to the resource.
        /// Required: Yes
        /// Type: List of Tag
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Tags")]
        public List<Tag> Tags { get; set; }

    }
}
