using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.LoadBalancer
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::LoadBalancer SubnetMapping
    /// Specifies a subnet to attach to an Application Load Balancer or a Network Load Balancer.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-loadbalancer-subnetmapping.html
    /// </summary>
    public class SubnetMapping
    {

        /// <summary>
        /// AllocationId
        /// [Network Load Balancers] The allocation ID of the Elastic IP address.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllocationId")]
        public Union<string, IntrinsicFunction> AllocationId { get; set; }

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
