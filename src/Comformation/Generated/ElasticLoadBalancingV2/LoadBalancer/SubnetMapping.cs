using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.LoadBalancer
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::LoadBalancer SubnetMapping
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-loadbalancer-subnetmapping.html
    /// </summary>
    public class SubnetMapping
    {

        /// <summary>
        /// AllocationId
        /// [Network Load Balancers] The allocation ID of the Elastic IP address for an internet-facing load
        /// balancer.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllocationId")]
        public Union<string, IntrinsicFunction> AllocationId { get; set; }

        /// <summary>
        /// IPv6Address
        /// [Network Load Balancers] The IPv6 address.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IPv6Address")]
        public Union<string, IntrinsicFunction> IPv6Address { get; set; }

        /// <summary>
        /// PrivateIPv4Address
        /// [Network Load Balancers] The private IPv4 address for an internal load balancer.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrivateIPv4Address")]
        public Union<string, IntrinsicFunction> PrivateIPv4Address { get; set; }

        /// <summary>
        /// SubnetId
        /// The ID of the subnet.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetId")]
        public Union<string, IntrinsicFunction> SubnetId { get; set; }

    }
}
